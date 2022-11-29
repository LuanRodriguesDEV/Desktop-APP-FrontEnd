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
    public partial class ProcurarProdutosNome : Form
    {
        private string Url = "https://localhost:7073/api/Produtos";
        public int ComandaId;
        private int PedidoId;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public ProcurarProdutosNome()
        {
            InitializeComponent();
            this.Padding = new Padding(3);
            this.BackColor = Color.FromArgb(107, 181, 174);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProcurarProdutosNome_Load(object sender, EventArgs e)
        {
            ListarProdutosAsync();
        }

        private void ProcurarProdutosNome_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private async Task ListarProdutosAsync()
        {
            string Uri = Url;



            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(Uri+"/GetProdutos"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        dgProdutos.AutoGenerateColumns = false;
                        var jsonContent = await response.Content.ReadAsStringAsync();
                        var comandas = JsonConvert.DeserializeObject<List<Produto>>(jsonContent);
                        dgProdutos.DataSource = comandas;

                        dgProdutos.Columns[0].DataPropertyName = "Id";
                        dgProdutos.Columns[1].DataPropertyName = "Nome";
                        dgProdutos.Columns[2].DataPropertyName = "Valor";


                    }

                }
            }
        }
        private async void ListarProdutosNome()
        {
            string Uri = Url;



            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(Uri +$"/GetProdutosByName/{txt_nome.Text}"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        dgProdutos.AutoGenerateColumns = false;
                        var jsonContent = await response.Content.ReadAsStringAsync();
                        var comandas = JsonConvert.DeserializeObject<List<Produto>>(jsonContent);
                        dgProdutos.DataSource = comandas;

                        dgProdutos.Columns[0].DataPropertyName = "Id";
                        dgProdutos.Columns[1].DataPropertyName = "Nome";
                        dgProdutos.Columns[2].DataPropertyName = "Valor";


                    }

                }
            }
        }

        

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(txt_QTD.Text != "")
            {
                VendaComanda.Instance.AddPedido(PedidoId, Convert.ToInt16(txt_QTD.Text));
                this.Close();
            }
        }

        private void dgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PedidoId = (int)dgProdutos.CurrentRow.Cells[0].Value;
            MessageBox.Show(PedidoId.ToString());
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            if(txt_nome.Text != "")
            {
                ListarProdutosNome();
            }
            else
            {
                ListarProdutosAsync();
            }
        }

        private void txt_QTD_KeyPress(object sender, KeyPressEventArgs e)
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
