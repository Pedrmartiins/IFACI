using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMUNICAÇÃO_SERIAL
{
    public partial class Form1 : Form
    {
        private StringBuilder BufferedRecebido = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
            timerCOM.Interval = 2000;
            timerCOM.Start();

        }

        private void Ligar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    if (Ligar.Text == "Ligar")
                    {
                        serialPort1.Write("L\n");
                        Ligar.Text = "Desligar";

                    }
                    else
                    {
                        serialPort1.Write("D\n");
                        Ligar.Text = "Ligar";

                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Erro ao enviar comando: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void atualizarListaCOMs()
        {
            comboBox1.Items.Clear();
            string[] portas = serialPort1.GetPortNames();

            if (portas.Length == 0)
            {
                comboBox1.Items.Add("Nenhuma porta encontrada");
                comboBox1.SelectedIndex = 0;
                return;
            }
            foreach (string porta in portas)
            {
                comboBox1.Items.Add(porta);
                comboBox1.SelectedIndex = 0;
            }
          
        }

        private void timerCOM_Tick(object sender, EventArgs e)
        {
            atualizarListaCOMs();
        }

        private void ConectarBt_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                desconectarSerial();

            }
            else
            {
                conectarSerial();
            }
            
        }
        private void conectarSerial()
        {
            if(comboBox1.SelectedIndex == null || comboBox1.SelectedItem.ToString() == "Nenhuma porta encontrada") {
                MessageBox.Show("Selecione uma porta COM valida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                serialPort1.PortName = comboBox1.SelectedItem.ToString();
                serialPort1.BaudRate = 9600;
                serialPort1.Parity = System.IO.Ports.Parity.None;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = System.IO.Ports.StopBits.One;
                serialPort1.Handshake = System.IO.Ports.Handshake.None;


                serialPort1.Open();

                ConectarBt.Text = "Desconectar";
                comboBox1.Enabled = false;

            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao conectar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        private void desconectarSerial()
        {
            try
            {
                serialPort1.Close();
                comboBox1.Enabled = true;
                ConectarBt.Text = "conectar";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao desconectar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)
             serialPort1.Close();

        }
       

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
        }
    }
