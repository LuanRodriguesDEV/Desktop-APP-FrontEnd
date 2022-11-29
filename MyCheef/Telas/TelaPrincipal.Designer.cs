namespace MyCheef
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnConfigs = new FontAwesome.Sharp.IconButton();
            this.btnRelatorios = new FontAwesome.Sharp.IconButton();
            this.btnCriarProdutos = new FontAwesome.Sharp.IconButton();
            this.btnVendas = new FontAwesome.Sharp.IconButton();
            this.btnComandaAberta = new FontAwesome.Sharp.IconButton();
            this.txtTurno = new System.Windows.Forms.Label();
            this.btnLoggout = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.TopTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.panelMenu.Controls.Add(this.btnConfigs);
            this.panelMenu.Controls.Add(this.btnRelatorios);
            this.panelMenu.Controls.Add(this.btnCriarProdutos);
            this.panelMenu.Controls.Add(this.btnVendas);
            this.panelMenu.Controls.Add(this.btnComandaAberta);
            this.panelMenu.Controls.Add(this.txtTurno);
            this.panelMenu.Controls.Add(this.btnLoggout);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.MinimumSize = new System.Drawing.Size(76, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 641);
            this.panelMenu.TabIndex = 0;
            // 
            // btnConfigs
            // 
            this.btnConfigs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfigs.FlatAppearance.BorderSize = 0;
            this.btnConfigs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigs.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigs.ForeColor = System.Drawing.Color.White;
            this.btnConfigs.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            this.btnConfigs.IconColor = System.Drawing.Color.White;
            this.btnConfigs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfigs.IconSize = 30;
            this.btnConfigs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigs.Location = new System.Drawing.Point(0, 338);
            this.btnConfigs.Name = "btnConfigs";
            this.btnConfigs.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConfigs.Size = new System.Drawing.Size(230, 46);
            this.btnConfigs.TabIndex = 13;
            this.btnConfigs.Tag = "       Configurações";
            this.btnConfigs.Text = "       Configurações";
            this.btnConfigs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfigs.UseVisualStyleBackColor = true;
            this.btnConfigs.Click += new System.EventHandler(this.btnConfigs_Click_1);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.White;
            this.btnRelatorios.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnRelatorios.IconColor = System.Drawing.Color.White;
            this.btnRelatorios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRelatorios.IconSize = 30;
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.Location = new System.Drawing.Point(0, 292);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRelatorios.Size = new System.Drawing.Size(230, 46);
            this.btnRelatorios.TabIndex = 12;
            this.btnRelatorios.Tag = "       Relatorios";
            this.btnRelatorios.Text = "       Relatorios";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnCriarProdutos
            // 
            this.btnCriarProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCriarProdutos.FlatAppearance.BorderSize = 0;
            this.btnCriarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarProdutos.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarProdutos.ForeColor = System.Drawing.Color.White;
            this.btnCriarProdutos.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnCriarProdutos.IconColor = System.Drawing.Color.White;
            this.btnCriarProdutos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCriarProdutos.IconSize = 30;
            this.btnCriarProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriarProdutos.Location = new System.Drawing.Point(0, 246);
            this.btnCriarProdutos.Name = "btnCriarProdutos";
            this.btnCriarProdutos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCriarProdutos.Size = new System.Drawing.Size(230, 46);
            this.btnCriarProdutos.TabIndex = 11;
            this.btnCriarProdutos.Tag = "       Criar Produtos";
            this.btnCriarProdutos.Text = "       Criar Produtos";
            this.btnCriarProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriarProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCriarProdutos.UseVisualStyleBackColor = true;
            this.btnCriarProdutos.Click += new System.EventHandler(this.btnCriarProdutos_Click_1);
            // 
            // btnVendas
            // 
            this.btnVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.ForeColor = System.Drawing.Color.White;
            this.btnVendas.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btnVendas.IconColor = System.Drawing.Color.White;
            this.btnVendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendas.IconSize = 30;
            this.btnVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendas.Location = new System.Drawing.Point(0, 200);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVendas.Size = new System.Drawing.Size(230, 46);
            this.btnVendas.TabIndex = 10;
            this.btnVendas.Tag = "       Cadastrar Venda";
            this.btnVendas.Text = "       Cadastrar Venda";
            this.btnVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click_1);
            // 
            // btnComandaAberta
            // 
            this.btnComandaAberta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComandaAberta.FlatAppearance.BorderSize = 0;
            this.btnComandaAberta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComandaAberta.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComandaAberta.ForeColor = System.Drawing.Color.White;
            this.btnComandaAberta.IconChar = FontAwesome.Sharp.IconChar.IdCardAlt;
            this.btnComandaAberta.IconColor = System.Drawing.Color.White;
            this.btnComandaAberta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComandaAberta.IconSize = 30;
            this.btnComandaAberta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComandaAberta.Location = new System.Drawing.Point(0, 154);
            this.btnComandaAberta.Name = "btnComandaAberta";
            this.btnComandaAberta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnComandaAberta.Size = new System.Drawing.Size(230, 46);
            this.btnComandaAberta.TabIndex = 9;
            this.btnComandaAberta.Tag = "       Comandas Abertas";
            this.btnComandaAberta.Text = "       Comandas Abertas";
            this.btnComandaAberta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComandaAberta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComandaAberta.UseVisualStyleBackColor = true;
            this.btnComandaAberta.Click += new System.EventHandler(this.btnComandaAberta_Click_1);
            // 
            // txtTurno
            // 
            this.txtTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTurno.AutoSize = true;
            this.txtTurno.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.txtTurno.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtTurno.Location = new System.Drawing.Point(87, 567);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(0, 25);
            this.txtTurno.TabIndex = 8;
            // 
            // btnLoggout
            // 
            this.btnLoggout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.btnLoggout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLoggout.FlatAppearance.BorderSize = 0;
            this.btnLoggout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoggout.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoggout.ForeColor = System.Drawing.Color.White;
            this.btnLoggout.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnLoggout.IconColor = System.Drawing.Color.White;
            this.btnLoggout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoggout.IconSize = 30;
            this.btnLoggout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoggout.Location = new System.Drawing.Point(0, 595);
            this.btnLoggout.Name = "btnLoggout";
            this.btnLoggout.Size = new System.Drawing.Size(230, 46);
            this.btnLoggout.TabIndex = 7;
            this.btnLoggout.Tag = "       LoggOut";
            this.btnLoggout.Text = "       LoggOut";
            this.btnLoggout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoggout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoggout.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 154);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(156, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 154);
            this.panel2.TabIndex = 2;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(74, 60);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyCheef.Properties.Resources.test;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.panelTitleBar.Controls.Add(this.TopTitle);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(230, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(741, 60);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // TopTitle
            // 
            this.TopTitle.AutoSize = true;
            this.TopTitle.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.TopTitle.Location = new System.Drawing.Point(26, 17);
            this.TopTitle.Name = "TopTitle";
            this.TopTitle.Size = new System.Drawing.Size(231, 25);
            this.TopTitle.TabIndex = 5;
            this.TopTitle.Text = "COMANDAS ABERTAS";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 25;
            this.btnMinimize.Location = new System.Drawing.Point(606, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 25);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 25;
            this.btnMaximize.Location = new System.Drawing.Point(651, 1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 25);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 40;
            this.btnClose.Location = new System.Drawing.Point(696, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(230, 60);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(741, 581);
            this.panelDesktop.TabIndex = 2;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 641);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(886, 600);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnLoggout;
        private System.Windows.Forms.Label TopTitle;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label txtTurno;
        private FontAwesome.Sharp.IconButton btnConfigs;
        private FontAwesome.Sharp.IconButton btnRelatorios;
        private FontAwesome.Sharp.IconButton btnCriarProdutos;
        private FontAwesome.Sharp.IconButton btnVendas;
        private FontAwesome.Sharp.IconButton btnComandaAberta;
    }
}

