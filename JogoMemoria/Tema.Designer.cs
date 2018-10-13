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
            this.tituloTemaLabel = new MaterialSkin.Controls.MaterialLabel();
            this.btnRedesSociais = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLOL = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.pictureBox1.Location = new System.Drawing.Point(50, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tituloTemaLabel
            // 
            this.tituloTemaLabel.AutoSize = true;
            this.tituloTemaLabel.BackColor = System.Drawing.Color.Transparent;
            this.tituloTemaLabel.Depth = 0;
            this.tituloTemaLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.tituloTemaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tituloTemaLabel.Location = new System.Drawing.Point(166, 164);
            this.tituloTemaLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tituloTemaLabel.Name = "tituloTemaLabel";
            this.tituloTemaLabel.Size = new System.Drawing.Size(125, 19);
            this.tituloTemaLabel.TabIndex = 1;
            this.tituloTemaLabel.Text = "escolha um tema";
            // 
            // btnRedesSociais
            // 
            this.btnRedesSociais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedesSociais.Depth = 0;
            this.btnRedesSociais.Location = new System.Drawing.Point(170, 212);
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
            this.btnLOL.Location = new System.Drawing.Point(170, 288);
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
            this.pictureBox2.Location = new System.Drawing.Point(566, 212);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 134);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Tema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(712, 469);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLOL);
            this.Controls.Add(this.btnRedesSociais);
            this.Controls.Add(this.tituloTemaLabel);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tema";
            this.Text = "Início / Tema";
            this.Load += new System.EventHandler(this.Tema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel tituloTemaLabel;
        private MaterialSkin.Controls.MaterialRaisedButton btnRedesSociais;
        private MaterialSkin.Controls.MaterialRaisedButton btnLOL;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}