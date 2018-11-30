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
            this.nomeJogador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempoJogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantErrors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeJogador
            // 
            this.nomeJogador.AutoSize = true;
            this.nomeJogador.BackColor = System.Drawing.Color.Transparent;
            this.nomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nomeJogador.Location = new System.Drawing.Point(148, 128);
            this.nomeJogador.Name = "nomeJogador";
            this.nomeJogador.Size = new System.Drawing.Size(108, 26);
            this.nomeJogador.TabIndex = 7;
            this.nomeJogador.Text = "Jogador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(76, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome:";
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
            this.nivel,
            this.tema,
            this.tempoJogo,
            this.quantErrors,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(81, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(705, 314);
            this.dataGridView1.TabIndex = 19;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(81, 157);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(705, 314);
            this.materialDivider1.TabIndex = 9;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // nivel
            // 
            this.nivel.HeaderText = "Nível";
            this.nivel.Name = "nivel";
            this.nivel.ReadOnly = true;
            this.nivel.Width = 160;
            // 
            // tema
            // 
            this.tema.HeaderText = "Tema";
            this.tema.Name = "tema";
            this.tema.ReadOnly = true;
            this.tema.Width = 160;
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
            // status
            // 
            this.status.HeaderText = "Status da Partida";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 110;
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 640);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeJogador);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(940, 640);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(940, 640);
            this.Name = "Ranking";
            this.Text = "Ranking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeJogador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn tema;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempoJogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantErrors;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}