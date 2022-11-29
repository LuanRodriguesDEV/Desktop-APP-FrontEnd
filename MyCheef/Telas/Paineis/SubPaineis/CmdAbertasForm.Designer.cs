namespace MyCheef
{
    partial class CmdAbertasForm
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
            this.btnAcessar = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.Label();
            this.txt_mesa = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAcessar
            // 
            this.btnAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessar.Image = global::MyCheef.Properties.Resources.LayoutCMD;
            this.btnAcessar.Location = new System.Drawing.Point(-2, -3);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(132, 181);
            this.btnAcessar.TabIndex = 2;
            this.btnAcessar.UseVisualStyleBackColor = true;
            // 
            // txt_codigo
            // 
            this.txt_codigo.AutoSize = true;
            this.txt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(129)))), ((int)(((byte)(137)))));
            this.txt_codigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_codigo.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt_codigo.Location = new System.Drawing.Point(19, 43);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_codigo.Size = new System.Drawing.Size(93, 59);
            this.txt_codigo.TabIndex = 3;
            this.txt_codigo.Text = "26";
            this.txt_codigo.Click += new System.EventHandler(this.txt_codigo_Click);
            // 
            // txt_mesa
            // 
            this.txt_mesa.AutoSize = true;
            this.txt_mesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(129)))), ((int)(((byte)(137)))));
            this.txt_mesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_mesa.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mesa.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt_mesa.Location = new System.Drawing.Point(70, 108);
            this.txt_mesa.Name = "txt_mesa";
            this.txt_mesa.Size = new System.Drawing.Size(42, 25);
            this.txt_mesa.TabIndex = 4;
            this.txt_mesa.Text = "26";
            // 
            // txtvalor
            // 
            this.txtvalor.AutoSize = true;
            this.txtvalor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(108)))));
            this.txtvalor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtvalor.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtvalor.Location = new System.Drawing.Point(26, 148);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(30, 18);
            this.txtvalor.TabIndex = 5;
            this.txtvalor.Text = "26";
            // 
            // CmdAbertasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(129, 175);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txt_mesa);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.btnAcessar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CmdAbertasForm";
            this.Text = "CmdAbertasForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Label txt_codigo;
        private System.Windows.Forms.Label txt_mesa;
        private System.Windows.Forms.Label txtvalor;
    }
}