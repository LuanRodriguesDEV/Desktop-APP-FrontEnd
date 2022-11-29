namespace MyCheef
{
    partial class VendaComanda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_Comanda = new System.Windows.Forms.TextBox();
            this.txt_QTD = new System.Windows.Forms.TextBox();
            this.txt_Desc = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnProcurarProdutos = new FontAwesome.Sharp.IconButton();
            this.btnFecharComanda = new FontAwesome.Sharp.IconButton();
            this.btn_Alterar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPedidos
            // 
            this.dgPedidos.AllowUserToAddRows = false;
            this.dgPedidos.AllowUserToDeleteRows = false;
            this.dgPedidos.AllowUserToResizeColumns = false;
            this.dgPedidos.AllowUserToResizeRows = false;
            this.dgPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.dgPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgPedidos.EnableHeadersVisualStyles = false;
            this.dgPedidos.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgPedidos.Location = new System.Drawing.Point(27, 114);
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.ReadOnly = true;
            this.dgPedidos.RowHeadersVisible = false;
            this.dgPedidos.RowHeadersWidth = 50;
            this.dgPedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgPedidos.Size = new System.Drawing.Size(688, 361);
            this.dgPedidos.TabIndex = 4;
            this.dgPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPedidos_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // txt_Comanda
            // 
            this.txt_Comanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.txt_Comanda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Comanda.Enabled = false;
            this.txt_Comanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Comanda.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Comanda.Location = new System.Drawing.Point(24, 24);
            this.txt_Comanda.Name = "txt_Comanda";
            this.txt_Comanda.Size = new System.Drawing.Size(85, 28);
            this.txt_Comanda.TabIndex = 6;
            // 
            // txt_QTD
            // 
            this.txt_QTD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.txt_QTD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_QTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QTD.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt_QTD.Location = new System.Drawing.Point(27, 74);
            this.txt_QTD.Name = "txt_QTD";
            this.txt_QTD.Size = new System.Drawing.Size(49, 28);
            this.txt_QTD.TabIndex = 8;
            this.txt_QTD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_QTD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_QTD_KeyDown);
            this.txt_QTD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QTD_KeyPress);
            // 
            // txt_Desc
            // 
            this.txt_Desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.txt_Desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Desc.Enabled = false;
            this.txt_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Desc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Desc.Location = new System.Drawing.Point(218, 74);
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Size = new System.Drawing.Size(315, 28);
            this.txt_Desc.TabIndex = 10;
            this.txt_Desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.txt_Codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Codigo.Location = new System.Drawing.Point(234, 24);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(66, 28);
            this.txt_Codigo.TabIndex = 9;
            this.txt_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Codigo_KeyDown);
            this.txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_KeyPress);
            // 
            // txt_total
            // 
            this.txt_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_total.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt_total.Location = new System.Drawing.Point(497, 481);
            this.txt_total.Name = "txt_total";
            this.txt_total.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_total.Size = new System.Drawing.Size(232, 33);
            this.txt_total.TabIndex = 11;
            this.txt_total.Text = "r& 0,00";
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_total.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(24, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Comanda";
            // 
            // txt_Valor
            // 
            this.txt_Valor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.txt_Valor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Valor.Enabled = false;
            this.txt_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Valor.Location = new System.Drawing.Point(82, 74);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(130, 28);
            this.txt_Valor.TabIndex = 15;
            this.txt_Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(28, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "QTD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(85, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(234, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Codigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(218, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Descrição";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(426, 489);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Total";
            // 
            // btnProcurarProdutos
            // 
            this.btnProcurarProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.btnProcurarProdutos.FlatAppearance.BorderSize = 0;
            this.btnProcurarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurarProdutos.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarProdutos.ForeColor = System.Drawing.Color.White;
            this.btnProcurarProdutos.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnProcurarProdutos.IconColor = System.Drawing.Color.White;
            this.btnProcurarProdutos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProcurarProdutos.IconSize = 30;
            this.btnProcurarProdutos.Location = new System.Drawing.Point(115, 19);
            this.btnProcurarProdutos.Name = "btnProcurarProdutos";
            this.btnProcurarProdutos.Size = new System.Drawing.Size(113, 32);
            this.btnProcurarProdutos.TabIndex = 25;
            this.btnProcurarProdutos.Tag = "Login";
            this.btnProcurarProdutos.Text = "Produtos";
            this.btnProcurarProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcurarProdutos.UseVisualStyleBackColor = false;
            this.btnProcurarProdutos.Click += new System.EventHandler(this.btnProcurarProdutos_Click);
            // 
            // btnFecharComanda
            // 
            this.btnFecharComanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.btnFecharComanda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFecharComanda.FlatAppearance.BorderSize = 0;
            this.btnFecharComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharComanda.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharComanda.ForeColor = System.Drawing.Color.White;
            this.btnFecharComanda.IconChar = FontAwesome.Sharp.IconChar.ThList;
            this.btnFecharComanda.IconColor = System.Drawing.Color.White;
            this.btnFecharComanda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFecharComanda.IconSize = 30;
            this.btnFecharComanda.Location = new System.Drawing.Point(0, 525);
            this.btnFecharComanda.Name = "btnFecharComanda";
            this.btnFecharComanda.Padding = new System.Windows.Forms.Padding(190, 0, 0, 0);
            this.btnFecharComanda.Size = new System.Drawing.Size(741, 56);
            this.btnFecharComanda.TabIndex = 23;
            this.btnFecharComanda.Tag = "Login";
            this.btnFecharComanda.Text = "Fechar Comanda";
            this.btnFecharComanda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFecharComanda.UseVisualStyleBackColor = false;
            this.btnFecharComanda.Click += new System.EventHandler(this.btnFecharComanda_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.btn_Alterar.FlatAppearance.BorderSize = 0;
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.Color.White;
            this.btn_Alterar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_Alterar.IconColor = System.Drawing.Color.White;
            this.btn_Alterar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Alterar.IconSize = 30;
            this.btn_Alterar.Location = new System.Drawing.Point(548, 70);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(113, 32);
            this.btn_Alterar.TabIndex = 26;
            this.btn_Alterar.Tag = "Login";
            this.btn_Alterar.Text = "Alterar ";
            this.btn_Alterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Alterar.UseVisualStyleBackColor = false;
            this.btn_Alterar.Visible = false;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // VendaComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(741, 581);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btnProcurarProdutos);
            this.Controls.Add(this.btnFecharComanda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_Desc);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.txt_QTD);
            this.Controls.Add(this.txt_Comanda);
            this.Controls.Add(this.dgPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VendaComanda";
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.VendaComanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.TextBox txt_Comanda;
        private System.Windows.Forms.TextBox txt_QTD;
        private System.Windows.Forms.TextBox txt_Desc;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnFecharComanda;
        private FontAwesome.Sharp.IconButton btnProcurarProdutos;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private FontAwesome.Sharp.IconButton btn_Alterar;
    }
}