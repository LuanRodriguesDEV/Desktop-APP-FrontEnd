using CustomMessageBox;
using MyCheef.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCheef.Telas.Paineis
{
    public partial class IniciarCaixa : Form
    {
        private string Url = "https://localhost:7073/api/Caixas";

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public IniciarCaixa()
        {
            InitializeComponent();
            this.Padding = new Padding(1);
            this.BackColor = Color.FromArgb(107, 181, 174);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IniciarCaixa_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        private async void CriarCaixa()
        {
            string Uri = Url;

            using (var client = new HttpClient())
            {
                var cat = new Caixa()
                {
                    DataAbertura = DateTime.Now,
                    SaldoInicial = Convert.ToDecimal(txt_Saldo.Text),
                    
                    
                };

                var newCatJson = JsonConvert.SerializeObject(cat);
                var stringContent = new StringContent(newCatJson, Encoding.UTF8, "application/json");
                //var convert =  StringContent(newCatJson, Encoding.UTF8,"application/json");
                var response = client.PostAsync(Uri, stringContent);
                if (response.Result.IsSuccessStatusCode)
                {
                    var jsonContent = await response.Result.Content.ReadAsStringAsync();
                    var caixa = JsonConvert.DeserializeObject<Caixa>(jsonContent);
                    Login.Instance.IniciarCaixaDialog(caixa);
                    RJMessageBox.Show("Caixa Aberto Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                   
                }
                else
                {
                    MessageBox.Show(response.ToString());
                }
            }


        }

        private void btnCriarCaixa_Click(object sender, EventArgs e)
        {
            CriarCaixa();
        }

        private void txt_Saldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
