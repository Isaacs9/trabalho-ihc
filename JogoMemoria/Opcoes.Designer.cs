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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioVerde = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioAzul = new System.Windows.Forms.RadioButton();
            this.radioPreto = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboNumTentavias = new System.Windows.Forms.ComboBox();
            this.textNumTentativas = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelNumTentativas = new System.Windows.Forms.Label();
            this.btnPronto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.radioVerde.Location = new System.Drawing.Point(412, 305);
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
            this.radioPreto.Location = new System.Drawing.Point(471, 305);
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
            this.label3.Location = new System.Drawing.Point(175, 335);
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
            this.comboNumTentavias.Location = new System.Drawing.Point(361, 338);
            this.comboNumTentavias.Name = "comboNumTentavias";
            this.comboNumTentavias.Size = new System.Drawing.Size(160, 21);
            this.comboNumTentavias.TabIndex = 12;
            this.comboNumTentavias.Text = "Não";
            this.comboNumTentavias.SelectedIndexChanged += new System.EventHandler(this.comboNumTentavias_SelectedIndexChanged);
            // 
            // textNumTentativas
            // 
            this.textNumTentativas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNumTentativas.BackColor = System.Drawing.Color.White;
            this.textNumTentativas.Depth = 0;
            this.textNumTentativas.ForeColor = System.Drawing.Color.Black;
            this.textNumTentativas.Hint = "";
            this.textNumTentativas.Location = new System.Drawing.Point(361, 375);
            this.textNumTentativas.MouseState = MaterialSkin.MouseState.HOVER;
            this.textNumTentativas.Name = "textNumTentativas";
            this.textNumTentativas.PasswordChar = '\0';
            this.textNumTentativas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textNumTentativas.SelectedText = "";
            this.textNumTentativas.SelectionLength = 0;
            this.textNumTentativas.SelectionStart = 0;
            this.textNumTentativas.Size = new System.Drawing.Size(88, 23);
            this.textNumTentativas.TabIndex = 13;
            this.textNumTentativas.Text = "10";
            this.textNumTentativas.UseSystemPasswordChar = false;
            this.textNumTentativas.Visible = false;
            // 
            // labelNumTentativas
            // 
            this.labelNumTentativas.AutoSize = true;
            this.labelNumTentativas.BackColor = System.Drawing.Color.Transparent;
            this.labelNumTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumTentativas.Location = new System.Drawing.Point(241, 374);
            this.labelNumTentativas.Name = "labelNumTentativas";
            this.labelNumTentativas.Size = new System.Drawing.Size(91, 24);
            this.labelNumTentativas.TabIndex = 14;
            this.labelNumTentativas.Text = "quantas ?";
            this.labelNumTentativas.Visible = false;
            // 
            // btnPronto
            // 
            this.btnPronto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPronto.BackgroundImage")));
            this.btnPronto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPronto.Depth = 0;
            this.btnPronto.Location = new System.Drawing.Point(455, 375);
            this.btnPronto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPronto.Name = "btnPronto";
            this.btnPronto.Primary = true;
            this.btnPronto.Size = new System.Drawing.Size(66, 23);
            this.btnPronto.TabIndex = 15;
            this.btnPronto.Text = "pronto";
            this.btnPronto.UseVisualStyleBackColor = true;
            this.btnPronto.Visible = false;
            this.btnPronto.Click += new System.EventHandler(this.btnPronto_Click);
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
            // Opcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 640);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnPronto);
            this.Controls.Add(this.labelNumTentativas);
            this.Controls.Add(this.textNumTentativas);
            this.Controls.Add(this.comboNumTentavias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioPreto);
            this.Controls.Add(this.radioAzul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioVerde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Opcoes";
            this.Text = "Início / Opções";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Opcoes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private MaterialSkin.Controls.MaterialSingleLineTextField textNumTentativas;
        private System.Windows.Forms.Label labelNumTentativas;
        private MaterialSkin.Controls.MaterialRaisedButton btnPronto;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}