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
using CustomMessageBox;
using MyCheef.Models;
using Newtonsoft.Json;

namespace MyCheef
{
    public partial class CriarCategoria : Form
    {
        private string Url = "https://localhost:7073/api/Categorias";
        public CriarCategoria()
        {
            InitializeComponent();
        }

        private void btnCriarCategoria_Click(object sender, EventArgs e)
        {
            if(txtNomeCategoria.Text != "")
            {
                CriarCategorias();
            }
        }
      
        

        private void CriarCategoria_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void CriarCategorias()
        {
            string Uri = Url;

            using (var client = new HttpClient())
            {
                var cat = new Categoria()
                {
                    Nome = txtNomeCategoria.Text,
                    
                    
                };

                var newCatJson = JsonConvert.SerializeObject(cat);
                var stringContent = new StringContent(newCatJson, Encoding.UTF8, "application/json");
               
                var response = client.PostAsync(Uri, stringContent);
                if (response.Result.IsSuccessStatusCode)
                {   
                    RJMessageBox.Show("Categoria Criada Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Teste();
                }
                else
                {
                    MessageBox.Show(response.ToString());
                }
            }                        
        }
        void Teste()
        {
            AtualizarLista();

        }
        private async void AtualizarLista()
        {
            string Uri = Url;



            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(Uri))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        dgCategorias.AutoGenerateColumns = false;
                        var jsonContent = await response.Content.ReadAsStringAsync();
                        var comandas = JsonConvert.DeserializeObject<List<Categoria>>(jsonContent);
                        dgCategorias.DataSource = comandas;
                        
                        dgCategorias.Columns[0].DataPropertyName = "Nome";
                       
                        
                    }

                }
            }
        }
    }
}
