namespace MyCheef
{
    partial class CriarCategoria
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
            this.btnCriarCategoria = new FontAwesome.Sharp.IconButton();
            this.dgCategorias = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriarCategoria
            // 
            this.btnCriarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.btnCriarCategoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCriarCategoria.FlatAppearance.BorderSize = 0;
            this.btnCriarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarCategoria.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCriarCategoria.IconChar = FontAwesome.Sharp.IconChar.ThList;
            this.btnCriarCategoria.IconColor = System.Drawing.Color.White;
            this.btnCriarCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCriarCategoria.IconSize = 30;
            this.btnCriarCategoria.Location = new System.Drawing.Point(0, 525);
            this.btnCriarCategoria.Name = "btnCriarCategoria";
            this.btnCriarCategoria.Padding = new System.Windows.Forms.Padding(190, 0, 0, 0);
            this.btnCriarCategoria.Size = new System.Drawing.Size(741, 56);
            this.btnCriarCategoria.TabIndex = 31;
            this.btnCriarCategoria.Tag = "Login";
            this.btnCriarCategoria.Text = "Criar Categoria";
            this.btnCriarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCriarCategoria.UseVisualStyleBackColor = false;
            this.btnCriarCategoria.Click += new System.EventHandler(this.btnCriarCategoria_Click);
            // 
            // dgCategorias
            // 
            this.dgCategorias.AllowUserToAddRows = false;
            this.dgCategorias.AllowUserToDeleteRows = false;
            this.dgCategorias.AllowUserToResizeColumns = false;
            this.dgCategorias.AllowUserToResizeRows = false;
            this.dgCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCategorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.dgCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoria});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCategorias.Enabled = false;
            this.dgCategorias.EnableHeadersVisualStyles = false;
            this.dgCategorias.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgCategorias.Location = new System.Drawing.Point(26, 93);
            this.dgCategorias.Name = "dgCategorias";
            this.dgCategorias.ReadOnly = true;
            this.dgCategorias.RowHeadersVisible = false;
            this.dgCategorias.RowHeadersWidth = 50;
            this.dgCategorias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgCategorias.Size = new System.Drawing.Size(688, 361);
            this.dgCategorias.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(28, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nome Categoria";
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCategoria.Location = new System.Drawing.Point(31, 38);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(306, 29);
            this.txtNomeCategoria.TabIndex = 24;
            // 
            // Categoria
            // 
            this.Categoria.FillWeight = 331.0674F;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // CriarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(741, 581);
            this.Controls.Add(this.btnCriarCategoria);
            this.Controls.Add(this.dgCategorias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CriarCategoria";
            this.Text = "CriarCategoria";
            this.Load += new System.EventHandler(this.CriarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCriarCategoria;
        private System.Windows.Forms.DataGridView dgCategorias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}