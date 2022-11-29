using CustomMessageBox;
using MyCheef.Models;
using Newtonsoft.Json;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MyCheef.Telas.Paineis;

namespace MyCheef
{
    public partial class Login : Form
    {
        public static Login Instance;
        private string Url = "https://localhost:7073/api/";
        private int borderSuze = 2;
        private Usuario usuario = null;
       

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Login()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSuze);
            this.BackColor = Color.FromArgb(107, 181, 174);
            Instance = this;
        }

        private void PanelDesktop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text != "" && txt_senha.Text != null)
            {
                GetUsuario();
            }
            else
            {
                RJMessageBox.Show("Preencha todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void GetUsuario()
        {
            string Uri = Url + "Usuarios/" + txt_nome.Text + "/" + txt_senha.Text;
            using (var client = new HttpClient())
            {
                try
                {
                   
                    using (var response = await client.GetAsync(Uri))
                    {
                        if (response.IsSuccessStatusCode)
                        {                          
                            var jsonContent = await response.Content.ReadAsStringAsync();
                            var funcionario = JsonConvert.DeserializeObject<Usuario>(jsonContent);
                            VerifyCaixa();
                            usuario = funcionario;
                           
                        

                        //RJMessageBox.Show($"Bem Vindo Sr(a): {funcionario.Nome}","Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Servidor Desligado : Erro :> {response.ToString()}");
                            RJMessageBox.Show($"Usuario Não Encontrado", "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                        }
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show($"Servidor Desligado : Erro :> {e.ToString()}");
                }

            }
        }
        private async void VerifyCaixa()
        {
            string Uri = Url;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(Uri + "Caixas/GetCaixa"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonContent = await response.Content.ReadAsStringAsync();
                        var Caixa = JsonConvert.DeserializeObject<Caixa>(jsonContent);
                        if(Caixa != null)
                            IniciarCaixaDialog(Caixa);
                        else
                            CreateCaixaDialog();
                    }
                    else
                    {
                        
                    }
                }
            }
        }
        public void IniciarCaixaDialog(Caixa caixa)
        {
            TelaPrincipal form = new TelaPrincipal();
            form.func = usuario;
            form.caixa = caixa;
            form.Show();
            this.Hide();
        }
        private void CreateCaixaDialog()
        {
            if (RJMessageBox.Show("Caixa não aberto, Deseja iniciar uma abertura de caixa?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                IniciarCaixa form = new IniciarCaixa();
                form.ShowDialog();
            }
            else
            {
                Application.Exit();
            }
        }
    } 
}
