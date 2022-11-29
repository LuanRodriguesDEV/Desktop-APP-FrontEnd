using CustomMessageBox;
using MyCheef.Dto;
using MyCheef.Models;
using MyCheef.Telas.Paineis;
using MyCheef.Telas.Paineis.SubPaineis;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCheef
{
    public partial class VendaComanda : Form
    {
        public static VendaComanda Instance = null;
        private string Url = "https://localhost:7073/api/";
        public Comanda comanda = null;
        private Produto produto = null;
        public VendaComanda()
        {
            InitializeComponent();
            Instance = this;
        }

        private void VendaComanda_Load(object sender, EventArgs e)
        {
            txt_Codigo.Focus();
            txt_Comanda.Text = comanda.Codigo.ToString();
            listaDePedidos();
            txt_QTD.Enabled = false;
        }

        private void btnFecharComanda_Click(object sender, EventArgs e)
        {
            TelaPrincipal.Instance.ReturnFormComandasAbertas();
        }

        private void btnProcurarProdutos_Click(object sender, EventArgs e)
        {
            ProcurarProdutosNome form = new ProcurarProdutosNome();
            form.ShowDialog();
        }

        private void txt_Codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txt_Codigo.Text != "")
                {
                    e.SuppressKeyPress = true;
                    ProcurarProduto(Convert.ToInt32(txt_Codigo.Text));
                }
                else
                {
                    RJMessageBox.Show("Digite um codigo de produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
           
        }
        private async void listaDePedidos()
        {
            string Uri = Url;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(Uri + "Pedidos/" + comanda.Id))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonContent = await response.Content.ReadAsStringAsync();
                        List<Pedido> Prod = JsonConvert.DeserializeObject<List<Pedido>>(jsonContent);
                        if (Prod != null)
                        {
                            var data = from c in Prod
                                       select new PedidoDto
                                       {
                                           Codigo = c.Id,
                                           Nome = c.Produto.Nome,
                                           QTD = c.Quantidade,
                                           Valor = c.Produto.Valor,
                                           Total = c.Produto.Valor * c.Quantidade,
                                          
                                           
                                       };

                            var x = data.ToList();
                            dgPedidos.DataSource = x;
                            decimal total = 0;
                            foreach (DataGridViewRow dr in dgPedidos.Rows)
                            {

                                
                                total = total + Convert.ToDecimal(dr.Cells[5].Value);
                            }
                            txt_total.Text = total.ToString("C2");

                        }
                        else
                        {
                            CreateCaixaDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show(response.ToString());
                    }
                    if(dgPedidos.Rows.Count > 0)
                    dgPedidos.Columns["Delete"].DisplayIndex = 6;
                }
            }
        }
        private async void ProcurarProduto(int id)
        {
            string Uri = Url;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(Uri + "Produtos/GetProdutosById/" + id))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonContent = await response.Content.ReadAsStringAsync();
                        Produto Prod = JsonConvert.DeserializeObject<Produto>(jsonContent);
                        if (Prod != null)
                        {
                            produto = Prod;
                            AchouProduto(produto.Valor, produto.Nome);
                        }
                        else
                        {
                            RJMessageBox.Show("Produto não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {

                    }
                }
            }
        }
        public async void AddPedido(int id,int qtd)
        {
                string Uri = Url;

            using (var client = new HttpClient())
            {
                Pedido cat = new Pedido()
                {
                    
                    ComandaId = comanda.Id,
                    
                    ProdutoId = id,

                    Quantidade = qtd,
                   
                    IsExcluido = false,
                    Horas = DateTime.Now,
                    
                    
                    
                    Produto = null,


                };

                var newCatJson = JsonConvert.SerializeObject(cat);
                var stringContent = new StringContent(newCatJson, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(Uri + "Pedidos", stringContent);
                if (response.IsSuccessStatusCode)
                {

                    RJMessageBox.Show("Pedido Criado Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listaDePedidos();
                    AdicionouProduto();
                }
                else
                {
                    MessageBox.Show(response.ToString());
                }
            }
        }
        private void AchouProduto(decimal Valor, string nome)
        {
            txt_Codigo.Enabled = false;
            txt_QTD.Enabled = true;
            txt_QTD.Focus();
            txt_Valor.Text = Valor.ToString();
            txt_Desc.Text = nome;
        }
        private void AdicionouProduto()
        {
            txt_Codigo.Enabled = true;
            txt_QTD.Enabled = false;
            txt_Codigo.Focus();
            txt_Valor.Text = "";
            txt_Desc.Text = "";
            txt_Codigo.Text = "";
            txt_QTD.Text = "";
        }

        private void CreateCaixaDialog()
        {
            throw new NotImplementedException();
        }

        private void IniciarCaixaDialog(IniciarCaixa caixa)
        {
            throw new NotImplementedException();
        }

        private void IniciarCaixaDialog(Caixa caixa)
        {
            throw new NotImplementedException();
        }

        private void txt_QTD_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txt_QTD.Text != "")
                {
                    e.SuppressKeyPress = true;
                    AddPedido(Convert.ToInt16(txt_Codigo.Text), Convert.ToInt16(txt_QTD.Text));
                }
                else
                {
                    RJMessageBox.Show("Digite uma quantidade", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
           
        }

        private void dgPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPedidos.Columns[e.ColumnIndex].Name == "Delete")
            {
                DataGridViewRow dr = dgPedidos.Rows[e.RowIndex];
                
                if (RJMessageBox.Show($"Deseja exluir o Pedido : {dr.Cells[2].Value.ToString()} ?", "Aviso",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeletePedido((int)dr.Cells[1].Value);
                }
            }
        }

        public async void DeletePedido(int id)
        {
            string Uri = Url;
            using (var client = new HttpClient())
            {
                
                using (var response = await client.DeleteAsync(Uri + $"Pedidos/{id}"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        listaDePedidos();
                    }
                    else
                    {
                        MessageBox.Show(response.ToString());
                    }
                    dgPedidos.Columns["Delete"].DisplayIndex = 6;
                }
            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            TrocarPedidoComanda form = new TrocarPedidoComanda();
            form.id = comanda.Id;
            form.ShowDialog();
        }

        private void txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
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
