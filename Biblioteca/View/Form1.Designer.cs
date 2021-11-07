
namespace Biblioteca
{
    partial class Form1
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
            this.btnListagemExemplar = new System.Windows.Forms.Button();
            this.btnAdicionarExemplar = new System.Windows.Forms.Button();
            this.btnRemoverExemplar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListagemExemplar
            // 
            this.btnListagemExemplar.Location = new System.Drawing.Point(81, 160);
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
            this.btnAdicionarExemplar.Location = new System.Drawing.Point(273, 160);
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
            this.btnRemoverExemplar.Location = new System.Drawing.Point(458, 160);
            this.btnRemoverExemplar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoverExemplar.Name = "btnRemoverExemplar";
            this.btnRemoverExemplar.Size = new System.Drawing.Size(86, 51);
            this.btnRemoverExemplar.TabIndex = 2;
            this.btnRemoverExemplar.Text = "Remover Exemplar";
            this.btnRemoverExemplar.UseVisualStyleBackColor = true;
            this.btnRemoverExemplar.Click += new System.EventHandler(this.btnRemoverExemplar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.btnRemoverExemplar);
            this.Controls.Add(this.btnAdicionarExemplar);
            this.Controls.Add(this.btnListagemExemplar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListagemExemplar;
        private System.Windows.Forms.Button btnAdicionarExemplar;
        private System.Windows.Forms.Button btnRemoverExemplar;
    }
}

