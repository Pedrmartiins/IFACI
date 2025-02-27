using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:\\IMAGENS\\Verde.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        //botao liga
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\IMAGENS\\Vermelho.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        //Botao desliga
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\IMAGENS\\Verde.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
