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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelTema = new System.Windows.Forms.Panel();
            this.voltarTema = new System.Windows.Forms.PictureBox();
            this.temaLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panelOpcoes = new System.Windows.Forms.Panel();
            this.opcoesLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnOpcao = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnJogar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panelTema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voltarTema)).BeginInit();
            this.panelOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTema
            // 
            this.panelTema.Controls.Add(this.temaLabel1);
            this.panelTema.Controls.Add(this.voltarTema);
            this.panelTema.Location = new System.Drawing.Point(-1, 64);
            this.panelTema.Name = "panelTema";
            this.panelTema.Size = new System.Drawing.Size(740, 389);
            this.panelTema.TabIndex = 5;
            this.panelTema.Visible = false;
            // 
            // voltarTema
            // 
            this.voltarTema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltarTema.Image = ((System.Drawing.Image)(resources.GetObject("voltarTema.Image")));
            this.voltarTema.Location = new System.Drawing.Point(55, 41);
            this.voltarTema.Name = "voltarTema";
            this.voltarTema.Size = new System.Drawing.Size(43, 35);
            this.voltarTema.TabIndex = 0;
            this.voltarTema.TabStop = false;
            this.voltarTema.Click += new System.EventHandler(this.voltarTema_Click);
            // 
            // temaLabel1
            // 
            this.temaLabel1.AutoSize = true;
            this.temaLabel1.Depth = 0;
            this.temaLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.temaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.temaLabel1.Location = new System.Drawing.Point(320, 46);
            this.temaLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.temaLabel1.Name = "temaLabel1";
            this.temaLabel1.Size = new System.Drawing.Size(125, 19);
            this.temaLabel1.TabIndex = 1;
            this.temaLabel1.Text = "escolha um tema";
            // 
            // panelOpcoes
            // 
            this.panelOpcoes.Controls.Add(this.opcoesLabel1);
            this.panelOpcoes.Controls.Add(this.pictureBox2);
            this.panelOpcoes.Location = new System.Drawing.Point(2, 64);
            this.panelOpcoes.Name = "panelOpcoes";
            this.panelOpcoes.Size = new System.Drawing.Size(740, 389);
            this.panelOpcoes.TabIndex = 6;
            this.panelOpcoes.Visible = false;
            // 
            // opcoesLabel1
            // 
            this.opcoesLabel1.AutoSize = true;
            this.opcoesLabel1.Depth = 0;
            this.opcoesLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.opcoesLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.opcoesLabel1.Location = new System.Drawing.Point(334, 51);
            this.opcoesLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.opcoesLabel1.Name = "opcoesLabel1";
            this.opcoesLabel1.Size = new System.Drawing.Size(59, 19);
            this.opcoesLabel1.TabIndex = 1;
            this.opcoesLabel1.Text = "opções";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(55, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 35);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(437, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 278);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Depth = 0;
            this.btnSair.Location = new System.Drawing.Point(75, 355);
            this.btnSair.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSair.Name = "btnSair";
            this.btnSair.Primary = true;
            this.btnSair.Size = new System.Drawing.Size(332, 58);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnOpcao
            // 
            this.btnOpcao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcao.Depth = 0;
            this.btnOpcao.Location = new System.Drawing.Point(75, 224);
            this.btnOpcao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpcao.Name = "btnOpcao";
            this.btnOpcao.Primary = true;
            this.btnOpcao.Size = new System.Drawing.Size(332, 58);
            this.btnOpcao.TabIndex = 2;
            this.btnOpcao.Text = "Opções";
            this.btnOpcao.UseVisualStyleBackColor = true;
            this.btnOpcao.Click += new System.EventHandler(this.btnOpcao_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJogar.BackgroundImage")));
            this.btnJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJogar.Depth = 0;
            this.btnJogar.Location = new System.Drawing.Point(75, 135);
            this.btnJogar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Primary = true;
            this.btnJogar.Size = new System.Drawing.Size(332, 58);
            this.btnJogar.TabIndex = 1;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnOpcao);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.panelTema);
            this.Controls.Add(this.panelOpcoes);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Memória";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelTema.ResumeLayout(false);
            this.panelTema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voltarTema)).EndInit();
            this.panelOpcoes.ResumeLayout(false);
            this.panelOpcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTema;
        private MaterialSkin.Controls.MaterialLabel temaLabel1;
        private System.Windows.Forms.PictureBox voltarTema;
        private System.Windows.Forms.Panel panelOpcoes;
        private MaterialSkin.Controls.MaterialLabel opcoesLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSair;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpcao;
        private MaterialSkin.Controls.MaterialRaisedButton btnJogar;
    }
}

