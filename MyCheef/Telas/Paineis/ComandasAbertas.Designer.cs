namespace MyCheef
{
    partial class ComandasAbertas
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
            this.layoutCMD = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCriarComanda = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // layoutCMD
            // 
            this.layoutCMD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutCMD.AutoScroll = true;
            this.layoutCMD.Location = new System.Drawing.Point(0, 1);
            this.layoutCMD.Name = "layoutCMD";
            this.layoutCMD.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.layoutCMD.Size = new System.Drawing.Size(725, 479);
            this.layoutCMD.TabIndex = 0;
            // 
            // btnCriarComanda
            // 
            this.btnCriarComanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.btnCriarComanda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCriarComanda.FlatAppearance.BorderSize = 0;
            this.btnCriarComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarComanda.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarComanda.ForeColor = System.Drawing.Color.White;
            this.btnCriarComanda.IconChar = FontAwesome.Sharp.IconChar.ThList;
            this.btnCriarComanda.IconColor = System.Drawing.Color.White;
            this.btnCriarComanda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCriarComanda.IconSize = 30;
            this.btnCriarComanda.Location = new System.Drawing.Point(0, 486);
            this.btnCriarComanda.Name = "btnCriarComanda";
            this.btnCriarComanda.Padding = new System.Windows.Forms.Padding(190, 0, 0, 0);
            this.btnCriarComanda.Size = new System.Drawing.Size(725, 56);
            this.btnCriarComanda.TabIndex = 8;
            this.btnCriarComanda.Tag = "Login";
            this.btnCriarComanda.Text = "Criar Comanda";
            this.btnCriarComanda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCriarComanda.UseVisualStyleBackColor = false;
            this.btnCriarComanda.Click += new System.EventHandler(this.btnCriarComanda_Click);
            // 
            // ComandasAbertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(725, 542);
            this.Controls.Add(this.btnCriarComanda);
            this.Controls.Add(this.layoutCMD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComandasAbertas";
            this.Text = "ComandasAbertas";
            this.Load += new System.EventHandler(this.ComandasAbertas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutCMD;
        private FontAwesome.Sharp.IconButton btnCriarComanda;
    }
}