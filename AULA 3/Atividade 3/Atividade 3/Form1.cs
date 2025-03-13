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
     int counter;
       


       
        public Avenida()
        {
           


            InitializeComponent();
            vermelho2.Enabled = false;
            verde1.Enabled = false;
            amarelo.Enabled = false;    
            amarelo2.Enabled = false;   
            verde2.Enabled = false;    
            vermelho1.Enabled = false;  
           
           

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

        private void vermelho1_Tick(object sender, EventArgs e)
        {
          
            pictureBox1.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\IFACI\AULA 3\imagens\verde.bmp");

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
            vermelho1.Enabled = false;
            verde1.Enabled = true ; 

        }

        private void verde1_Tick(object sender, EventArgs e)
       
            {
               
                pictureBox1.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\IFACI\AULA 3\imagens\amarelo.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
            verde1.Enabled = false; 
            amarelo.Enabled = true ;    
           
            }

        private void amarelo_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\IFACI\AULA 3\imagens\vermelho.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
            vermelho1.Enabled=true;
            amarelo.Enabled=false;
        }

       

        private void verde2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\IFACI\AULA 3\imagens\amarelo.bmp");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            verde2.Enabled=false;
            amarelo2.Enabled=true;
        }

        private void amarelo2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\IFACI\AULA 3\imagens\vermelho.bmp");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            vermelho2.Enabled = true;
            amarelo2.Enabled = false;
        }


        private void vermelho2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\IFACI\AULA 3\imagens\verde.bmp");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            vermelho2.Enabled=false;
            verde2.Enabled = true;  
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult bc;
            MessageBoxButtons bot = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Asterisk;
            MessageBoxDefaultButton bd = MessageBoxDefaultButton.Button1;
            bc = MessageBox.Show("Deseja Ligar ?", "Confirmação", bot, icon, bd);
            // bc = MessageBox.Show ("Message\nBox", "Informação", bot, icon, bd);

            switch (bc)
            {
                case DialogResult.Yes:
                    Text = "SIM";
                    pictureBox1.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\IFACI\AULA 3\imagens\vermelho.bmp");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    vermelho1.Enabled = true;


                    pictureBox2.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\IFACI\AULA 3\imagens\verde.bmp");
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    verde2.Enabled = true;
                    break;
                case DialogResult.No:
                    Text = "NAO";
                    break;
            }


           

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult bc;
            MessageBoxButtons bot = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Asterisk;
            MessageBoxDefaultButton bd = MessageBoxDefaultButton.Button1;
            bc = MessageBox.Show("Deseja Desligar ?", "Confirmação", bot, icon, bd);
            // bc = MessageBox.Show ("Message\nBox", "Informação", bot, icon, bd);

            switch (bc)
            {
                case DialogResult.Yes:
                    Text = "SIM";
                    vermelho2.Enabled = false;
                    verde1.Enabled = false;
                    amarelo.Enabled = false;
                    amarelo2.Enabled = false;
                    verde2.Enabled = false;
                    vermelho1.Enabled = false;

                    pictureBox1.Image = null;
                    pictureBox2.Image = null;

                    break;
                case DialogResult.No:
                    Text = "NAO";
                    break;
            }



            
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            vermelho2.Enabled = false;
            verde1.Enabled = false;
            amarelo.Enabled = false;
            amarelo2.Enabled = false;
            verde2.Enabled = false;
            vermelho1.Enabled = false;

            pictureBox2.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\IFACI\AULA 3\imagens\amarelo.bmp");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\IFACI\AULA 3\imagens\amarelo.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            await Task.Delay(5000);

            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }

       
    }
    
}
