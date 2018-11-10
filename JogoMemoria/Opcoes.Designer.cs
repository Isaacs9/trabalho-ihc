namespace JogoMemoria
{
    partial class Opcoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opcoes));
            this.label1 = new System.Windows.Forms.Label();
            this.radioVerde = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioAzul = new System.Windows.Forms.RadioButton();
            this.radioPreto = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboNumTentavias = new System.Windows.Forms.ComboBox();
            this.labelNumTentativas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkLolSom = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPronto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textNumTentativas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNumTentativas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "opções";
            // 
            // radioVerde
            // 
            this.radioVerde.AutoSize = true;
            this.radioVerde.BackColor = System.Drawing.Color.Transparent;
            this.radioVerde.Location = new System.Drawing.Point(465, 305);
            this.radioVerde.Name = "radioVerde";
            this.radioVerde.Size = new System.Drawing.Size(53, 17);
            this.radioVerde.TabIndex = 7;
            this.radioVerde.TabStop = true;
            this.radioVerde.Text = "Verde";
            this.radioVerde.UseVisualStyleBackColor = false;
            this.radioVerde.CheckedChanged += new System.EventHandler(this.radioVerde_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "tema";
            // 
            // radioAzul
            // 
            this.radioAzul.AutoSize = true;
            this.radioAzul.BackColor = System.Drawing.Color.Transparent;
            this.radioAzul.Location = new System.Drawing.Point(361, 304);
            this.radioAzul.Name = "radioAzul";
            this.radioAzul.Size = new System.Drawing.Size(45, 17);
            this.radioAzul.TabIndex = 9;
            this.radioAzul.TabStop = true;
            this.radioAzul.Text = "Azul";
            this.radioAzul.UseVisualStyleBackColor = false;
            this.radioAzul.CheckedChanged += new System.EventHandler(this.radioAzul_CheckedChanged);
            // 
            // radioPreto
            // 
            this.radioPreto.AutoSize = true;
            this.radioPreto.BackColor = System.Drawing.Color.Transparent;
            this.radioPreto.Location = new System.Drawing.Point(412, 305);
            this.radioPreto.Name = "radioPreto";
            this.radioPreto.Size = new System.Drawing.Size(50, 17);
            this.radioPreto.TabIndex = 10;
            this.radioPreto.TabStop = true;
            this.radioPreto.Text = "Preto";
            this.radioPreto.UseVisualStyleBackColor = false;
            this.radioPreto.CheckedChanged += new System.EventHandler(this.radioPreto_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "limite de tentativas";
            // 
            // comboNumTentavias
            // 
            this.comboNumTentavias.FormattingEnabled = true;
            this.comboNumTentavias.ItemHeight = 13;
            this.comboNumTentavias.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.comboNumTentavias.Location = new System.Drawing.Point(361, 485);
            this.comboNumTentavias.Name = "comboNumTentavias";
            this.comboNumTentavias.Size = new System.Drawing.Size(149, 21);
            this.comboNumTentavias.TabIndex = 12;
            this.comboNumTentavias.Text = "Não";
            this.comboNumTentavias.SelectedIndexChanged += new System.EventHandler(this.comboNumTentavias_SelectedIndexChanged);
            // 
            // labelNumTentativas
            // 
            this.labelNumTentativas.AutoSize = true;
            this.labelNumTentativas.BackColor = System.Drawing.Color.Transparent;
            this.labelNumTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumTentativas.Location = new System.Drawing.Point(241, 521);
            this.labelNumTentativas.Name = "labelNumTentativas";
            this.labelNumTentativas.Size = new System.Drawing.Size(91, 24);
            this.labelNumTentativas.TabIndex = 14;
            this.labelNumTentativas.Text = "quantas ?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "habilitar som";
            // 
            // checkLolSom
            // 
            this.checkLolSom.AutoSize = true;
            this.checkLolSom.BackColor = System.Drawing.Color.Transparent;
            this.checkLolSom.Location = new System.Drawing.Point(361, 343);
            this.checkLolSom.Name = "checkLolSom";
            this.checkLolSom.Size = new System.Drawing.Size(120, 17);
            this.checkLolSom.TabIndex = 20;
            this.checkLolSom.Text = "League Of Legends";
            this.checkLolSom.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(612, 304);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 135);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // btnPronto
            // 
            this.btnPronto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPronto.BackgroundImage")));
            this.btnPronto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPronto.Depth = 0;
            this.btnPronto.Location = new System.Drawing.Point(402, 563);
            this.btnPronto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPronto.Name = "btnPronto";
            this.btnPronto.Primary = true;
            this.btnPronto.Size = new System.Drawing.Size(66, 32);
            this.btnPronto.TabIndex = 15;
            this.btnPronto.Text = "Salvar";
            this.btnPronto.UseVisualStyleBackColor = true;
            this.btnPronto.Click += new System.EventHandler(this.btnPronto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "nome do jogador:";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField1.BackColor = System.Drawing.Color.White;
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.ForeColor = System.Drawing.Color.Black;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(360, 386);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(149, 23);
            this.materialSingleLineTextField1.TabIndex = 21;
            this.materialSingleLineTextField1.Text = "Jogador 1";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(161, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "quantidade de jogos ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(126, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "armazenados no ranking:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(361, 438);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(149, 20);
            this.numericUpDown1.TabIndex = 26;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // textNumTentativas
            // 
            this.textNumTentativas.Location = new System.Drawing.Point(361, 525);
            this.textNumTentativas.Name = "textNumTentativas";
            this.textNumTentativas.Size = new System.Drawing.Size(149, 20);
            this.textNumTentativas.TabIndex = 27;
            this.textNumTentativas.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Opcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 640);
            this.Controls.Add(this.textNumTentativas);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.checkLolSom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnPronto);
            this.Controls.Add(this.labelNumTentativas);
            this.Controls.Add(this.comboNumTentavias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioPreto);
            this.Controls.Add(this.radioAzul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioVerde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(940, 640);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(940, 640);
            this.Name = "Opcoes";
            this.Text = "Início / Opções";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Opcoes_FormClosed);
            this.Load += new System.EventHandler(this.Opcoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNumTentativas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioVerde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioAzul;
        private System.Windows.Forms.RadioButton radioPreto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboNumTentavias;
        private System.Windows.Forms.Label labelNumTentativas;
        private MaterialSkin.Controls.MaterialRaisedButton btnPronto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkLolSom;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown textNumTentativas;
    }
}