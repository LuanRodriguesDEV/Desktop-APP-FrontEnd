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

namespace MyCheef.Telas.Paineis.SubPaineis
{
    public partial class TrocarPedidoComanda : Form
    {
        public int id = 0;
        private string Url = "https://localhost:7073/api/";
        public TrocarPedidoComanda()
        {
            InitializeComponent();
        }

        private async Task ListarPedidosAsync()
        {
            string Uri = Url;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(Uri + "Pedidos/" + id))
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

                        }
                        else
                        {
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show(response.ToString());
                    }
                   
                }
            }
        }

        private void TrocarPedidoComanda_Load(object sender, EventArgs e)
        {
            ListarPedidosAsync();
        }
    }
}
