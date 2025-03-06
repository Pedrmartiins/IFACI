using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Atividade_3
   
{
    public partial class Avenida : Form

    {
        Timer timer;

       
        public Avenida()
        {
            InitializeComponent();
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\IFACI\AULA 3\imagens\vermelho.bmp");
            pictureBox1.Tag = "vermelho";   
           
        }

       

       

        private void police_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.policiamilitar.sp.gov.br/");
        }

       

        private void Avenida_Load(object sender, EventArgs e)
        {
            toolStripLabel1.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Tag.ToString() == "vermelho")
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox2.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\IFACI\AULA 3\imagens\verde.bmp");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Tag = "verde";
                

            }
            else if (pictureBox1.Tag.ToString() == "verde")
            {
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;

                pictureBox1.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\IFACI\AULA 3\imagens\vermelho.bmp");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Tag = "vermelho";
            }

        }
    }
}
