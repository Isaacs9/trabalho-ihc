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
            this.voltarDificuldade = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltarDificuldade)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(594, 317);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 134);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnLOL
            // 
            this.btnLOL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLOL.BackgroundImage")));
            this.btnLOL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLOL.Depth = 0;
            this.btnLOL.Location = new System.Drawing.Point(212, 387);
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
            this.btnRedesSociais.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRedesSociais.BackgroundImage")));
            this.btnRedesSociais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedesSociais.Depth = 0;
            this.btnRedesSociais.Location = new System.Drawing.Point(212, 311);
            this.btnRedesSociais.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRedesSociais.Name = "btnRedesSociais";
            this.btnRedesSociais.Primary = true;
            this.btnRedesSociais.Size = new System.Drawing.Size(332, 58);
            this.btnRedesSociais.TabIndex = 7;
            this.btnRedesSociais.Text = "Nutella";
            this.btnRedesSociais.UseVisualStyleBackColor = true;
            this.btnRedesSociais.Click += new System.EventHandler(this.btnRedesSociais_Click);
            // 
            // voltarDificuldade
            // 
            this.voltarDificuldade.BackColor = System.Drawing.Color.Transparent;
            this.voltarDificuldade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltarDificuldade.Image = ((System.Drawing.Image)(resources.GetObject("voltarDificuldade.Image")));
            this.voltarDificuldade.Location = new System.Drawing.Point(12, 76);
            this.voltarDificuldade.Name = "voltarDificuldade";
            this.voltarDificuldade.Size = new System.Drawing.Size(39, 35);
            this.voltarDificuldade.TabIndex = 5;
            this.voltarDificuldade.TabStop = false;
            this.voltarDificuldade.Click += new System.EventHandler(this.voltarDificuldade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "escolha um nível";
            // 
            // Dificuldade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLOL);
            this.Controls.Add(this.btnRedesSociais);
            this.Controls.Add(this.voltarDificuldade);
            this.Location = new System.Drawing.Point(50, 103);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dificuldade";
            this.Text = "Início / Tema / Dificuldade";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dificuldade_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltarDificuldade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialRaisedButton btnLOL;
        private MaterialSkin.Controls.MaterialRaisedButton btnRedesSociais;
        private System.Windows.Forms.PictureBox voltarDificuldade;
        private System.Windows.Forms.Label label1;
    }
}