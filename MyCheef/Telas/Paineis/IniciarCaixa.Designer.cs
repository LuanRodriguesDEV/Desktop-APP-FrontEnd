namespace MyCheef.Telas.Paineis
{
    partial class IniciarCaixa
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
            this.btnCriarCaixa = new FontAwesome.Sharp.IconButton();
            this.txt_Saldo = new System.Windows.Forms.TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.TopTitle = new System.Windows.Forms.Label();
            this.PanelDesktop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.PanelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCriarCaixa
            // 
            this.btnCriarCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.btnCriarCaixa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCriarCaixa.FlatAppearance.BorderSize = 0;
            this.btnCriarCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarCaixa.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarCaixa.ForeColor = System.Drawing.Color.White;
            this.btnCriarCaixa.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btnCriarCaixa.IconColor = System.Drawing.Color.White;
            this.btnCriarCaixa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCriarCaixa.IconSize = 30;
            this.btnCriarCaixa.Location = new System.Drawing.Point(0, 121);
            this.btnCriarCaixa.Name = "btnCriarCaixa";
            this.btnCriarCaixa.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btnCriarCaixa.Size = new System.Drawing.Size(361, 56);
            this.btnCriarCaixa.TabIndex = 9;
            this.btnCriarCaixa.Tag = "Login";
            this.btnCriarCaixa.Text = "ABRIR CAIXA";
            this.btnCriarCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCriarCaixa.UseVisualStyleBackColor = false;
            this.btnCriarCaixa.Click += new System.EventHandler(this.btnCriarCaixa_Click);
            // 
            // txt_Saldo
            // 
            this.txt_Saldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Saldo.Location = new System.Drawing.Point(52, 69);
            this.txt_Saldo.Name = "txt_Saldo";
            this.txt_Saldo.Size = new System.Drawing.Size(263, 31);
            this.txt_Saldo.TabIndex = 10;
            this.txt_Saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Saldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Saldo_KeyPress);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlLight;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(12, 68);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 12;
            this.iconPictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 40;
            this.btnClose.Location = new System.Drawing.Point(316, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 25);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TopTitle
            // 
            this.TopTitle.AutoSize = true;
            this.TopTitle.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.TopTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TopTitle.Location = new System.Drawing.Point(47, 41);
            this.TopTitle.Name = "TopTitle";
            this.TopTitle.Size = new System.Drawing.Size(136, 25);
            this.TopTitle.TabIndex = 14;
            this.TopTitle.Text = "Saldo Inicial";
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.PanelDesktop.Controls.Add(this.txt_Saldo);
            this.PanelDesktop.Controls.Add(this.iconPictureBox2);
            this.PanelDesktop.Controls.Add(this.btnClose);
            this.PanelDesktop.Controls.Add(this.TopTitle);
            this.PanelDesktop.Controls.Add(this.btnCriarCaixa);
            this.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktop.Location = new System.Drawing.Point(0, 0);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.Size = new System.Drawing.Size(361, 177);
            this.PanelDesktop.TabIndex = 15;
            // 
            // IniciarCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(361, 177);
            this.Controls.Add(this.PanelDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IniciarCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IniciarCaixa";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IniciarCaixa_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.PanelDesktop.ResumeLayout(false);
            this.PanelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCriarCaixa;
        private System.Windows.Forms.TextBox txt_Saldo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label TopTitle;
        private System.Windows.Forms.Panel PanelDesktop;
    }
}