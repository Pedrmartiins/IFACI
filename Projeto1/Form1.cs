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

            aGauge1.Value = 10;
            aGauge1.Update();
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
                
                serialPort1.WriteLine("8");
            }

        }

        private void desliga_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Aluno\\Desktop\\IFACI\\Projeto1\\Imagens\\cinza.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (serialPort1.IsOpen)
            {
                
                serialPort1.WriteLine("9");
               
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
                    btConectar.Text = "DESCONECTAR";
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

            {
                string temperatura = "", tensao = "", dados;
                dados = serialPort1.ReadLine().Trim();  // Lê a linha da serial e remove espaços extras

                // Verifique se a linha contém o caracter '/' e se ela pode ser dividida corretamente
                if (dados.Contains("/") && dados.Split('/').Length == 2)
                {
                    try
                    {
                        // Divida os dados e obtenha a tensão e a temperatura
                        string[] partes = dados.Split('/');
                        tensao = partes[0];
                        temperatura = partes[1];

                        
                        float tensaoFloat, temperaturaFloat;
                        if (float.TryParse(tensao, out tensaoFloat) && float.TryParse(temperatura, out temperaturaFloat))
                        {

                            float porcentagem = (tensaoFloat / 100.0f) * 20f;
                    
                            aGauge1.Value = porcentagem;
                            aGauge1.Update();

                            aGauge2.Value = temperaturaFloat/100;
                            aGauge2.Update();  

                            Console.WriteLine(dados,porcentagem);
                         
                        }
                        else
                        {
                            Console.WriteLine("Erro na conversão dos dados: " + dados);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro ao processar dados da serial: " + ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Formato de dados inesperado: " + dados);
                }


            }


                //string temperatura, tensao, dados;

                //dados = serialPort1.ReadLine();


                //temperatura = dados.Split('/')[1];
                //tensao = dados.Split('/')[0];



                ////aGauge1.Value = Convert.ToSingle(temperatura);
                ////aGauge1.Update();

                //aGauge1.Value = Convert.ToSingle(tensao);
                //aGauge1.Update();

                //if (dados != "")
                //{
                //    Console.WriteLine(dados);
                //}



                serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();


           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
