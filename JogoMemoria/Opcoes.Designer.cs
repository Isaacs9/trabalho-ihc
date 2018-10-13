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
            this.tituloTemaLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.tituloTemaLabel.Size = new System.Drawing.Size(59, 19);
            this.tituloTemaLabel.TabIndex = 3;
            this.tituloTemaLabel.Text = "opções";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Opcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 451);
            this.Controls.Add(this.tituloTemaLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Opcoes";
            this.Text = "Início / Opções";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel tituloTemaLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}