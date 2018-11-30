namespace JogoMemoria
{
    partial class Ranking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ranking));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempoJogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantErrors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.cleanRanking = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jogador,
            this.status,
            this.nivel,
            this.tema,
            this.tempoJogo,
            this.quantErrors});
            this.dataGridView1.Location = new System.Drawing.Point(60, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(793, 314);
            this.dataGridView1.TabIndex = 19;
            // 
            // jogador
            // 
            this.jogador.HeaderText = "Jogador";
            this.jogador.Name = "jogador";
            this.jogador.ReadOnly = true;
            this.jogador.Width = 150;
            // 
            // status
            // 
            this.status.HeaderText = "Status da Partida";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 110;
            // 
            // nivel
            // 
            this.nivel.HeaderText = "Nível";
            this.nivel.Name = "nivel";
            this.nivel.ReadOnly = true;
            this.nivel.Width = 120;
            // 
            // tema
            // 
            this.tema.HeaderText = "Tema";
            this.tema.Name = "tema";
            this.tema.ReadOnly = true;
            this.tema.Width = 140;
            // 
            // tempoJogo
            // 
            this.tempoJogo.HeaderText = "Tempo de Jogo";
            this.tempoJogo.Name = "tempoJogo";
            this.tempoJogo.ReadOnly = true;
            this.tempoJogo.Width = 120;
            // 
            // quantErrors
            // 
            this.quantErrors.HeaderText = "Quantidade de Erros";
            this.quantErrors.Name = "quantErrors";
            this.quantErrors.ReadOnly = true;
            this.quantErrors.Width = 110;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(60, 157);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(793, 314);
            this.materialDivider1.TabIndex = 9;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // cleanRanking
            // 
            this.cleanRanking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cleanRanking.Depth = 0;
            this.cleanRanking.Location = new System.Drawing.Point(734, 118);
            this.cleanRanking.MouseState = MaterialSkin.MouseState.HOVER;
            this.cleanRanking.Name = "cleanRanking";
            this.cleanRanking.Primary = true;
            this.cleanRanking.Size = new System.Drawing.Size(119, 33);
            this.cleanRanking.TabIndex = 20;
            this.cleanRanking.Text = "Limpar Ranking";
            this.cleanRanking.UseVisualStyleBackColor = true;
            this.cleanRanking.Click += new System.EventHandler(this.cleanRanking_Click);
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 640);
            this.Controls.Add(this.cleanRanking);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialDivider1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(940, 640);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(940, 640);
            this.Name = "Ranking";
            this.Text = "Ranking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn tema;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempoJogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantErrors;
        private MaterialSkin.Controls.MaterialRaisedButton cleanRanking;
    }
}