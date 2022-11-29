namespace MyCheef
{
    partial class CriarProdutosMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCriarProdutos = new FontAwesome.Sharp.IconButton();
            this.btnCriarCategoria = new FontAwesome.Sharp.IconButton();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCriarProdutos
            // 
            this.btnCriarProdutos.FlatAppearance.BorderSize = 0;
            this.btnCriarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarProdutos.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarProdutos.ForeColor = System.Drawing.Color.White;
            this.btnCriarProdutos.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnCriarProdutos.IconColor = System.Drawing.Color.White;
            this.btnCriarProdutos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCriarProdutos.IconSize = 30;
            this.btnCriarProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriarProdutos.Location = new System.Drawing.Point(12, 10);
            this.btnCriarProdutos.Name = "btnCriarProdutos";
            this.btnCriarProdutos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCriarProdutos.Size = new System.Drawing.Size(197, 49);
            this.btnCriarProdutos.TabIndex = 3;
            this.btnCriarProdutos.Tag = "       Criar Produtos";
            this.btnCriarProdutos.Text = "       Criar Produtos";
            this.btnCriarProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriarProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCriarProdutos.UseVisualStyleBackColor = true;
            this.btnCriarProdutos.Click += new System.EventHandler(this.btnCriarProdutos_Click);
            // 
            // btnCriarCategoria
            // 
            this.btnCriarCategoria.FlatAppearance.BorderSize = 0;
            this.btnCriarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarCategoria.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCriarCategoria.IconChar = FontAwesome.Sharp.IconChar.Tshirt;
            this.btnCriarCategoria.IconColor = System.Drawing.Color.White;
            this.btnCriarCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCriarCategoria.IconSize = 30;
            this.btnCriarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriarCategoria.Location = new System.Drawing.Point(215, 10);
            this.btnCriarCategoria.Name = "btnCriarCategoria";
            this.btnCriarCategoria.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCriarCategoria.Size = new System.Drawing.Size(197, 49);
            this.btnCriarCategoria.TabIndex = 4;
            this.btnCriarCategoria.Tag = "       Criar Produtos";
            this.btnCriarCategoria.Text = "       Criar Categoria";
            this.btnCriarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCriarCategoria.UseVisualStyleBackColor = true;
            this.btnCriarCategoria.Click += new System.EventHandler(this.btnCriarCategoria_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.btnCriarProdutos);
            this.topPanel.Controls.Add(this.btnCriarCategoria);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(741, 62);
            this.topPanel.TabIndex = 5;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 62);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(741, 519);
            this.panelDesktop.TabIndex = 6;
            // 
            // CriarProdutosMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(741, 581);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CriarProdutosMain";
            this.Text = "CriarProdutosMain";
            this.Load += new System.EventHandler(this.CriarProdutosMain_Load);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCriarProdutos;
        private FontAwesome.Sharp.IconButton btnCriarCategoria;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panelDesktop;
    }
}