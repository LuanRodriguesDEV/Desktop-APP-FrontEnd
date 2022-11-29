using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCheef
{
    public partial class CriarProdutosMain : Form
    {
        public static CriarProdutosMain Instance;
        private Button currentButton;
        public CriarProdutosMain()
        {
            InitializeComponent();
        }

        private void CriarProdutosMain_Load(object sender, EventArgs e)
        {
            Instance = this;
            btnCriarProdutos.PerformClick();
        }

        public void NoCategories()
        {
            
            btnCriarCategoria.PerformClick();
        }

        private void ActivateButton(object btnSender)
        {

            if (btnSender != null)
            {

                if (currentButton != (Button)btnSender)
                {
                    
                    DisableButton();
                    Color color = Color.FromArgb(107, 181, 174);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;

                }
            }
        }


        void OpenForm(Form form)
        {
            if (panelDesktop.Controls.Count > 0)
                panelDesktop.Controls.RemoveAt(0);
            form.TopLevel = false;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(form);
            form.Show();
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in topPanel.Controls)
            {
                if (previousBtn is Button)
                {


                    previousBtn.BackColor = Color.FromArgb(22, 25, 34);
                    previousBtn.ForeColor = Color.FromArgb(107, 181, 174);

                }
            }
        }

        private void btnCriarProdutos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenForm(new CriarProdutos());
        }

        private void btnCriarCategoria_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenForm(new CriarCategoria());
        }
    }
}
