namespace JogoMemoria
{
    partial class FormPrincipal
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
            this.btnJogar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnOpcao = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSair = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // btnJogar
            // 
            this.btnJogar.Depth = 0;
            this.btnJogar.Location = new System.Drawing.Point(276, 172);
            this.btnJogar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Primary = true;
            this.btnJogar.Size = new System.Drawing.Size(225, 58);
            this.btnJogar.TabIndex = 1;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            // 
            // btnOpcao
            // 
            this.btnOpcao.Depth = 0;
            this.btnOpcao.Location = new System.Drawing.Point(276, 252);
            this.btnOpcao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpcao.Name = "btnOpcao";
            this.btnOpcao.Primary = true;
            this.btnOpcao.Size = new System.Drawing.Size(225, 58);
            this.btnOpcao.TabIndex = 2;
            this.btnOpcao.Text = "Opções";
            this.btnOpcao.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Depth = 0;
            this.btnSair.Location = new System.Drawing.Point(276, 327);
            this.btnSair.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSair.Name = "btnSair";
            this.btnSair.Primary = true;
            this.btnSair.Size = new System.Drawing.Size(225, 58);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnOpcao);
            this.Controls.Add(this.btnJogar);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Memória";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnJogar;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpcao;
        private MaterialSkin.Controls.MaterialRaisedButton btnSair;
    }
}

