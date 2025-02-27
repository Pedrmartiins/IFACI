using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pisca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:\\Imagens\\1.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Tag = "Laranja";

           


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Tag.ToString() == "Laranja")
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox2.Image = Image.FromFile("C:\\Imagens\\2.bmp");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Tag = "cinza";

            }else if (pictureBox1.Tag.ToString() == "cinza")
            {
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;

                pictureBox1.Image = Image.FromFile("C:\\Imagens\\1.bmp");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Tag = "Laranja";
            }
        }
    }
}
