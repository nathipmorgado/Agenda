namespace Agenda.UIDesktop
{
    partial class Form1
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
            this.lblContatoNovo = new System.Windows.Forms.Label();
            this.txtContatoNovo = new System.Windows.Forms.TextBox();
            this.lblContatoSalvo = new System.Windows.Forms.Label();
            this.txtContatoSalvo = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContatoNovo
            // 
            this.lblContatoNovo.AutoSize = true;
            this.lblContatoNovo.Location = new System.Drawing.Point(14, 19);
            this.lblContatoNovo.Name = "lblContatoNovo";
            this.lblContatoNovo.Size = new System.Drawing.Size(94, 17);
            this.lblContatoNovo.TabIndex = 0;
            this.lblContatoNovo.Text = "Contato Novo";
            // 
            // txtContatoNovo
            // 
            this.txtContatoNovo.Location = new System.Drawing.Point(17, 39);
            this.txtContatoNovo.Name = "txtContatoNovo";
            this.txtContatoNovo.Size = new System.Drawing.Size(210, 22);
            this.txtContatoNovo.TabIndex = 1;
            // 
            // lblContatoSalvo
            // 
            this.lblContatoSalvo.AutoSize = true;
            this.lblContatoSalvo.Location = new System.Drawing.Point(14, 85);
            this.lblContatoSalvo.Name = "lblContatoSalvo";
            this.lblContatoSalvo.Size = new System.Drawing.Size(96, 17);
            this.lblContatoSalvo.TabIndex = 2;
            this.lblContatoSalvo.Text = "Contato Salvo";
            // 
            // txtContatoSalvo
            // 
            this.txtContatoSalvo.Location = new System.Drawing.Point(17, 105);
            this.txtContatoSalvo.Name = "txtContatoSalvo";
            this.txtContatoSalvo.Size = new System.Drawing.Size(205, 22);
            this.txtContatoSalvo.TabIndex = 3;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(165, 162);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(61, 31);
            this.BtnSalvar.TabIndex = 4;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.txtContatoSalvo);
            this.Controls.Add(this.lblContatoSalvo);
            this.Controls.Add(this.txtContatoNovo);
            this.Controls.Add(this.lblContatoNovo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContatoNovo;
        private System.Windows.Forms.TextBox txtContatoNovo;
        private System.Windows.Forms.Label lblContatoSalvo;
        private System.Windows.Forms.TextBox txtContatoSalvo;
        private System.Windows.Forms.Button BtnSalvar;
    }
}

