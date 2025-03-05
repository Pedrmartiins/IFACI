using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Objetivo_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\IFACI\Aula 2\Aula 2\Atividade\images\verde.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\IFACI\Aula 2\Aula 2\Atividade\images\vermelho.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult bc;
            MessageBoxButtons bot = MessageBoxButtons.OKCancel;
            MessageBoxIcon icon = MessageBoxIcon.Asterisk;
            MessageBoxDefaultButton bd = MessageBoxDefaultButton.Button1;
            bc = MessageBox.Show("Deseja sair ?", "Confirmação", bot, icon, bd);
            // bc = MessageBox.Show ("Message\nBox", "Informação", bot, icon, bd);

            switch (bc)
            {
                case DialogResult.OK:
                  Text = "SIM";
                    Application.Exit(); 
                    break;
                case DialogResult.Cancel:
                   Text = "NAO";
                    break;
            }
        }
    }
}
