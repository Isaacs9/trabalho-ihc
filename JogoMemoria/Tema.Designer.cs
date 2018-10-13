namespace JogoMemoria
{
    partial class Tema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tema));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRedesSociais = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLOL = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnRedesSociais
            // 
            this.btnRedesSociais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedesSociais.Depth = 0;
            this.btnRedesSociais.Location = new System.Drawing.Point(212, 312);
            this.btnRedesSociais.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRedesSociais.Name = "btnRedesSociais";
            this.btnRedesSociais.Primary = true;
            this.btnRedesSociais.Size = new System.Drawing.Size(332, 58);
            this.btnRedesSociais.TabIndex = 2;
            this.btnRedesSociais.Text = "Redes Sociais";
            this.btnRedesSociais.UseVisualStyleBackColor = true;
            this.btnRedesSociais.Click += new System.EventHandler(this.btnRedesSociais_Click);
            // 
            // btnLOL
            // 
            this.btnLOL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLOL.Depth = 0;
            this.btnLOL.Location = new System.Drawing.Point(212, 388);
            this.btnLOL.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLOL.Name = "btnLOL";
            this.btnLOL.Primary = true;
            this.btnLOL.Size = new System.Drawing.Size(332, 58);
            this.btnLOL.TabIndex = 3;
            this.btnLOL.Text = "League of Legends";
            this.btnLOL.UseVisualStyleBackColor = true;
            this.btnLOL.Click += new System.EventHandler(this.btnLOL_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(608, 312);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 134);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "escolha um tema";
            // 
            // Tema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(940, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLOL);
            this.Controls.Add(this.btnRedesSociais);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tema";
            this.Text = "Início / Tema";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tema_FormClosed);
            this.Load += new System.EventHandler(this.Tema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnRedesSociais;
        private MaterialSkin.Controls.MaterialRaisedButton btnLOL;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}