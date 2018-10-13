namespace JogoMemoria
{
    partial class Dificuldade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dificuldade));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLOL = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRedesSociais = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tituloDificuldadeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.voltarDificuldade = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltarDificuldade)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(552, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 134);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnLOL
            // 
            this.btnLOL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLOL.Depth = 0;
            this.btnLOL.Location = new System.Drawing.Point(170, 287);
            this.btnLOL.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLOL.Name = "btnLOL";
            this.btnLOL.Primary = true;
            this.btnLOL.Size = new System.Drawing.Size(332, 58);
            this.btnLOL.TabIndex = 8;
            this.btnLOL.Text = "Raíz";
            this.btnLOL.UseVisualStyleBackColor = true;
            // 
            // btnRedesSociais
            // 
            this.btnRedesSociais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedesSociais.Depth = 0;
            this.btnRedesSociais.Location = new System.Drawing.Point(170, 211);
            this.btnRedesSociais.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRedesSociais.Name = "btnRedesSociais";
            this.btnRedesSociais.Primary = true;
            this.btnRedesSociais.Size = new System.Drawing.Size(332, 58);
            this.btnRedesSociais.TabIndex = 7;
            this.btnRedesSociais.Text = "Nutella";
            this.btnRedesSociais.UseVisualStyleBackColor = true;
            this.btnRedesSociais.Click += new System.EventHandler(this.btnRedesSociais_Click);
            // 
            // tituloDificuldadeLabel
            // 
            this.tituloDificuldadeLabel.AutoSize = true;
            this.tituloDificuldadeLabel.BackColor = System.Drawing.Color.Transparent;
            this.tituloDificuldadeLabel.Depth = 0;
            this.tituloDificuldadeLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.tituloDificuldadeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tituloDificuldadeLabel.Location = new System.Drawing.Point(167, 164);
            this.tituloDificuldadeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tituloDificuldadeLabel.Name = "tituloDificuldadeLabel";
            this.tituloDificuldadeLabel.Size = new System.Drawing.Size(122, 19);
            this.tituloDificuldadeLabel.TabIndex = 6;
            this.tituloDificuldadeLabel.Text = "escolha um nível";
            // 
            // voltarDificuldade
            // 
            this.voltarDificuldade.BackColor = System.Drawing.Color.Transparent;
            this.voltarDificuldade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltarDificuldade.Image = ((System.Drawing.Image)(resources.GetObject("voltarDificuldade.Image")));
            this.voltarDificuldade.Location = new System.Drawing.Point(50, 103);
            this.voltarDificuldade.Name = "voltarDificuldade";
            this.voltarDificuldade.Size = new System.Drawing.Size(39, 35);
            this.voltarDificuldade.TabIndex = 5;
            this.voltarDificuldade.TabStop = false;
            this.voltarDificuldade.Click += new System.EventHandler(this.voltarDificuldade_Click);
            // 
            // Dificuldade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 469);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLOL);
            this.Controls.Add(this.btnRedesSociais);
            this.Controls.Add(this.tituloDificuldadeLabel);
            this.Controls.Add(this.voltarDificuldade);
            this.Location = new System.Drawing.Point(50, 103);
            this.Name = "Dificuldade";
            this.Text = "Início / Tema / Dificuldade";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltarDificuldade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialRaisedButton btnLOL;
        private MaterialSkin.Controls.MaterialRaisedButton btnRedesSociais;
        private MaterialSkin.Controls.MaterialLabel tituloDificuldadeLabel;
        private System.Windows.Forms.PictureBox voltarDificuldade;
    }
}