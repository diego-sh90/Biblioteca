
namespace Biblioteca
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnListagemExemplar = new System.Windows.Forms.Button();
            this.btnAdicionarExemplar = new System.Windows.Forms.Button();
            this.btnRemoverExemplar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtCodExemplar = new System.Windows.Forms.TextBox();
            this.lblCodTipoExemplar = new System.Windows.Forms.Label();
            this.txtCodRegistro = new System.Windows.Forms.TextBox();
            this.lblCodRegistro = new System.Windows.Forms.Label();
            this.dtgListaExemplar = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CodRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodTipoExemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaExemplar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListagemExemplar
            // 
            this.btnListagemExemplar.Location = new System.Drawing.Point(484, 460);
            this.btnListagemExemplar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListagemExemplar.Name = "btnListagemExemplar";
            this.btnListagemExemplar.Size = new System.Drawing.Size(94, 51);
            this.btnListagemExemplar.TabIndex = 0;
            this.btnListagemExemplar.Text = "Listagem Exemplares";
            this.btnListagemExemplar.UseVisualStyleBackColor = true;
            this.btnListagemExemplar.Click += new System.EventHandler(this.btnListagemExemplar_Click);
            // 
            // btnAdicionarExemplar
            // 
            this.btnAdicionarExemplar.Location = new System.Drawing.Point(610, 460);
            this.btnAdicionarExemplar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdicionarExemplar.Name = "btnAdicionarExemplar";
            this.btnAdicionarExemplar.Size = new System.Drawing.Size(86, 51);
            this.btnAdicionarExemplar.TabIndex = 1;
            this.btnAdicionarExemplar.Text = "Adicionar Exemplar";
            this.btnAdicionarExemplar.UseVisualStyleBackColor = true;
            this.btnAdicionarExemplar.Click += new System.EventHandler(this.btnAdicionarExemplar_Click);
            // 
            // btnRemoverExemplar
            // 
            this.btnRemoverExemplar.Location = new System.Drawing.Point(725, 460);
            this.btnRemoverExemplar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoverExemplar.Name = "btnRemoverExemplar";
            this.btnRemoverExemplar.Size = new System.Drawing.Size(86, 51);
            this.btnRemoverExemplar.TabIndex = 2;
            this.btnRemoverExemplar.Text = "Remover Exemplar";
            this.btnRemoverExemplar.UseVisualStyleBackColor = true;
            this.btnRemoverExemplar.Click += new System.EventHandler(this.btnRemoverExemplar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(27, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 15);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(70, 28);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(497, 23);
            this.txtTitulo.TabIndex = 4;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(610, 28);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(201, 23);
            this.txtArea.TabIndex = 6;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(573, 31);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(34, 15);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Area:";
            // 
            // txtCodExemplar
            // 
            this.txtCodExemplar.Location = new System.Drawing.Point(371, 61);
            this.txtCodExemplar.Name = "txtCodExemplar";
            this.txtCodExemplar.Size = new System.Drawing.Size(100, 23);
            this.txtCodExemplar.TabIndex = 8;
            // 
            // lblCodTipoExemplar
            // 
            this.lblCodTipoExemplar.AutoSize = true;
            this.lblCodTipoExemplar.Location = new System.Drawing.Point(258, 64);
            this.lblCodTipoExemplar.Name = "lblCodTipoExemplar";
            this.lblCodTipoExemplar.Size = new System.Drawing.Size(110, 15);
            this.lblCodTipoExemplar.TabIndex = 7;
            this.lblCodTipoExemplar.Text = "Cod.Tipo Exemplar:";
            // 
            // txtCodRegistro
            // 
            this.txtCodRegistro.Location = new System.Drawing.Point(108, 61);
            this.txtCodRegistro.Name = "txtCodRegistro";
            this.txtCodRegistro.Size = new System.Drawing.Size(100, 23);
            this.txtCodRegistro.TabIndex = 10;
            // 
            // lblCodRegistro
            // 
            this.lblCodRegistro.AutoSize = true;
            this.lblCodRegistro.Location = new System.Drawing.Point(27, 64);
            this.lblCodRegistro.Name = "lblCodRegistro";
            this.lblCodRegistro.Size = new System.Drawing.Size(78, 15);
            this.lblCodRegistro.TabIndex = 9;
            this.lblCodRegistro.Text = "Cod.Registro:";
            // 
            // dtgListaExemplar
            // 
            this.dtgListaExemplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaExemplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodRegistro,
            this.Titulo,
            this.CodTipoExemplar,
            this.Area});
            this.dtgListaExemplar.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgListaExemplar.Location = new System.Drawing.Point(28, 91);
            this.dtgListaExemplar.Name = "dtgListaExemplar";
            this.dtgListaExemplar.RowTemplate.Height = 25;
            this.dtgListaExemplar.Size = new System.Drawing.Size(784, 365);
            this.dtgListaExemplar.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CodRegistro
            // 
            this.CodRegistro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CodRegistro.HeaderText = "CodRegistro";
            this.CodRegistro.Name = "CodRegistro";
            this.CodRegistro.ReadOnly = true;
            this.CodRegistro.Width = 97;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // CodTipoExemplar
            // 
            this.CodTipoExemplar.HeaderText = "CodTipoExemplar";
            this.CodTipoExemplar.Name = "CodTipoExemplar";
            this.CodTipoExemplar.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(848, 522);
            this.Controls.Add(this.dtgListaExemplar);
            this.Controls.Add(this.txtCodRegistro);
            this.Controls.Add(this.lblCodRegistro);
            this.Controls.Add(this.txtCodExemplar);
            this.Controls.Add(this.lblCodTipoExemplar);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnRemoverExemplar);
            this.Controls.Add(this.btnAdicionarExemplar);
            this.Controls.Add(this.btnListagemExemplar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.Text = "+ Biblioteca + ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaExemplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListagemExemplar;
        private System.Windows.Forms.Button btnAdicionarExemplar;
        private System.Windows.Forms.Button btnRemoverExemplar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtCodExemplar;
        private System.Windows.Forms.Label lblCodTipoExemplar;
        private System.Windows.Forms.TextBox txtCodRegistro;
        private System.Windows.Forms.Label lblCodRegistro;
        private System.Windows.Forms.DataGridView dtgListaExemplar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodTipoExemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
    }
}

