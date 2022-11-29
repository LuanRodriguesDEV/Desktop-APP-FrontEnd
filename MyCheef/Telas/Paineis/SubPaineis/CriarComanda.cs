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
    public partial class CriarComanda : Form
    {
        private string Url = "https://localhost:7073/api/Comandas";
        public CriarComanda()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLCriar_Click(object sender, EventArgs e)
        {
            if(txtComanda.Text != "")
            {
                if (txtMesa.Text != "")
                {
                    CriarComandas();
                }
                else             
                    RJMessageBox.Show("Digite uma Mesa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);         
            }
            else
                RJMessageBox.Show("Digite uma comanda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }
        private async void CriarComandas()
        {
            string Uri = Url;

            using (var client = new HttpClient())
            {
                Comanda cat = new Comanda()
                {
                    Codigo = Convert.ToInt32(txtComanda.Text),
                    Mesa = Convert.ToInt32(txtMesa.Text),
                    Valor = 0,
                    Estado = true,
                    Abertura = DateTime.Now,
                   
                    CaixaId = TelaPrincipal.Instance.caixa.Id
                };

                var newCatJson = JsonConvert.SerializeObject(cat);
                var stringContent = new StringContent(newCatJson, Encoding.UTF8, "application/json");
               
                var response = client.PostAsync(Uri, stringContent);
                if (response.Result.IsSuccessStatusCode)
                {
                    var jsonContent = await response.Result.Content.ReadAsStringAsync();
                    var funcionario = JsonConvert.DeserializeObject<Comanda>(jsonContent);
                  
                        if (RJMessageBox.Show("Comanda criada com sucesso , deseja acessa-la?", "Sucesso!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            TelaPrincipal.Instance.AcessarComanda(funcionario);
                        }
                        else
                        {
                            ComandasAbertas.Instance.ListarComandas();
                        }
                        this.Close();
                   
                   

                }
                else
                {
                    RJMessageBox.Show("Comanda Ja existente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtComanda_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMesa_KeyPress(object sender, KeyPressEventArgs e)
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
