using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomMessageBox;
using MyCheef.Models;

namespace MyCheef
{
    public partial class CmdAbertasForm : Form
    {
        
        private Comanda comanda = null;
        

        public CmdAbertasForm()
        {
            InitializeComponent();
        }

        public void Set(Comanda comandas)
        {
            comanda = comandas;

            txt_mesa.Text = comanda.Mesa.ToString();
            txt_codigo.Text = comanda.Codigo.ToString();
            txtvalor.Text = comanda.Valor.ToString("C2");
        }

        private void txt_codigo_Click(object sender, EventArgs e)
        {
            if(RJMessageBox.Show($"Deseja acessar a comanda codigo: {comanda.Codigo}","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TelaPrincipal.Instance.AcessarComanda(comanda);
            }
        }
    }
}
