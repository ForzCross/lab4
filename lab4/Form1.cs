using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ЛР №4");
        }

        private void новоеРаспознаваниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "bmp|*.bmp|png|*.png|jpg|*.jpg";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Bitmap.FromFile(fileDialog.FileName);
            }
        }
    }
}
