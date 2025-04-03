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
using System.Drawing.Text;

namespace Temp_arduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void lerTemperatura(object sender, EventArgs e)
        {

            byte[] dados = new byte[2];
            string valor;

            valor = serialPort1.ReadExisting();

            if (valor != "")
            {
                thermControl1.UpdateControl(Convert.ToInt32(valor));

                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
            }


        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(lerTemperatura));

        }

        private void bt_iniciar_Click(object sender, EventArgs e)
        {
            if (txporta.Text != "")
            {
                serialPort1.PortName = txporta.Text;
            if (!serialPort1.IsOpen)
               serialPort1.Open();
               
            }
        }

        private void bt_finalizar_Click(object sender, EventArgs e)
        {
            if(!serialPort1.IsOpen)
                serialPort1.Close();   
            Application.Exit();
        }
    }
}