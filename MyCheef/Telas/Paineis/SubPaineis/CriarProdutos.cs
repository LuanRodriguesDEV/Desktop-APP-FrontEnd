using CustomMessageBox;
using MyCheef.Dto;
using MyCheef.Models;
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
    public partial class CriarProdutos : Form
    {
        
        private string Url = "https://localhost:7073/api";
        public CriarProdutos()
        {
            InitializeComponent();
        }
        private async void AtualizarComboBox()
        {
                string Uri = Url;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(Uri + "/Categorias"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonContent = await response.Content.ReadAsStringAsync();
                        var categoria = JsonConvert.DeserializeObject<List<Categoria>>(jsonContent);
                        if (categoria.Count == 0) return;
                        cbCategorias.DataSource = categoria;
                        cbCategorias.ValueMember = "Id";
                        cbCategorias.DisplayMember = "Nome";
                    }
                }
            }
            
            
        }
        private async void AtualizarLista()
        {
            string Uri = Url;



            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(Uri+"/Produtos/GetProdutos"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        //dgProdutos.AutoGenerateColumns = false;
                        var jsonContent = await response.Content.ReadAsStringAsync();
                        var comandas = JsonConvert.DeserializeObject<List<Produto>>(jsonContent);

                        var data = from c in comandas
                            select new ProdutoDto
                            {
                                Nome = c.Nome,
                                Valor = c.Valor,
                                Categoria = c.Categoria == null ? "Sem Categoria" : c.Categoria.Nome,
                                Imprimir = c.IsImprimir
                            };

                        var x = data.ToList();
                        dgProdutos.DataSource = x;
                        


                    }
                    else
                    {
                        MessageBox.Show("Erro","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void CriarProdutos_Load(object sender, EventArgs e)
        {
            AtualizarComboBox();
            AtualizarLista();
        }
        

        private void btnCriarProduto_Click(object sender, EventArgs e)
        {
            if(cbCategorias.Items.Count == 0)
            {
                if(RJMessageBox.Show("Ainda não possui Categorias para registrar um produto","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                CriarProdutosMain.Instance.NoCategories();
            }else
            if(txtNome.Text != "")          
                if(txtValor.Text != "")               
                    if(cbCategorias.Text != "")
                        CreateProducts();  
        }
        private void CreateProducts()
        {
            string Uri = Url;

            using (var client = new HttpClient())
            {
                Produto produto = new Produto()
                {

                    Nome = txtNome.Text,
                    Valor = Convert.ToDecimal(txtValor.Text),
                    IsImprimir = cbImprimir.Checked,
                    CategoriaId = (int)cbCategorias.SelectedValue,
                    Categoria = null,
                   
                   
                };

                var newCatJson = JsonConvert.SerializeObject(produto);
                var stringContent = new StringContent(newCatJson, Encoding.UTF8, "application/json");
                //var convert =  StringContent(newCatJson, Encoding.UTF8,"application/json");
                var response = client.PostAsync(Uri+"/Produtos/Create/", stringContent);
                if (response.Result.IsSuccessStatusCode)
                {
                    RJMessageBox.Show("Produto Criada Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarLista();
                }
                else
                {
                    MessageBox.Show(response.ToString());
                }
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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
