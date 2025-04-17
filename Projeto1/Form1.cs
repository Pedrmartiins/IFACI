using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Projeto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:\\Users\\Aluno\\Desktop\\IFACI\\Projeto1\\Imagens\\cinza.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            atualizarListaCOMs();
        }

        private void aGauge1_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {

        }



        private void liga_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Aluno\\Desktop\\IFACI\\Projeto1\\Imagens\\verde.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            if (serialPort1.IsOpen)
            {
                
                serialPort1.WriteLine("1");
            }

        }

        private void desliga_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Aluno\\Desktop\\IFACI\\Projeto1\\Imagens\\cinza.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (serialPort1.IsOpen)
            {
                
                serialPort1.WriteLine("0");
            }
        }
        private void atualizarListaCOMs()
        {
            int i;
            bool quantDiferente;
            i = 0;
            quantDiferente = false;

            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }

                }
            }
            else
            {
                quantDiferente = true;

            }
            if (quantDiferente == false)
            {
                return;
            }

            comboBox1.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);

            }
            comboBox1.SelectedIndex = 0;

        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort1.Open();

                }
                catch
                {
                    return;
                }
                if (serialPort1.IsOpen)
                {
                    btConectar.Text = "desconectar";
                    comboBox1.Enabled = false;
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    comboBox1.Enabled = true;
                    btConectar.Text = "conectar";

                }
                catch
                {
                    return;
                }
            }
        }

       

        private void serialPort1_DataReceived (object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(lerDadosSerial));
        }

        private void lerDadosSerial (object sender, EventArgs e)
        {
            string temperatura, tensao, dados;
       
            dados = serialPort1.ReadExisting();

            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();


            Console.WriteLine(dados);
        }
    }
}
