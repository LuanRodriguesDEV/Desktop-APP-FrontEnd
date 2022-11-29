using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyCheef.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace MyCheef
{
    public partial class ComandasAbertas : Form
    {
        private string Url = "https://localhost:7073/api/Comandas";
        public static ComandasAbertas Instance;
        public ComandasAbertas()
        {
            InitializeComponent();
        }

        private void ComandasAbertas_Load(object sender, EventArgs e)
        {
            Instance = this;
            ListarComandas();
        }
        public void ListarComandas()
        {
            try
            {
                GetComandas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCriarComanda_Click(object sender, EventArgs e)
        {
            CriarComanda form = new CriarComanda();
            form.ShowDialog();
        }
        private async void GetComandas()
        {
            layoutCMD.Controls.Clear();
            string Uri = Url;
           
          

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(Uri))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonContent = await response.Content.ReadAsStringAsync();
                        var comandas = JsonConvert.DeserializeObject<List<Comanda>>(jsonContent);

                        foreach (var com in comandas)
                        {
                           
                            CmdAbertasForm f1 = new CmdAbertasForm();
                            f1.TopLevel = false;
                            f1.Visible = true;
                            f1.Set(com);
                            layoutCMD.Controls.Add(f1);
                        }
                    }

                }
            }
             
        }
    }
}
