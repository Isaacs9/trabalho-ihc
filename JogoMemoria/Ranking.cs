using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace JogoMemoria
{
    public partial class Ranking : MaterialForm
    {
        public Ranking()
        {
            InitializeComponent();
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.ClearSelection();
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;    switch (Program.cor)
            {
                case "verde":
                    dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 127, 56);
                    break;
                case "preto":
                    dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 34, 35);
                    break;
                case "azul":
                    dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 72, 178);
                    break;
                default:
                    dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 127, 56);
                    break;
            }
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //set data
            Program.playerRankings.ForEach(f =>
            {
                dataGridView1.Rows.Add(f.jogador,f.status, f.nivel, f.tema, f.tempoDeJogo + " Segundos", f.quantidadeErros);
            });
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
