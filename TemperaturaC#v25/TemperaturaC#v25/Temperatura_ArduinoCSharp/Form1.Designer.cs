namespace Temperatura_ArduinoCSharp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btIniciar = new System.Windows.Forms.Button();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.lbPorta = new System.Windows.Forms.Label();
            this.txPorta = new System.Windows.Forms.TextBox();
            this.thermControl1 = new ThermometerControl.ThermControl();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(32, 521);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(121, 53);
            this.btIniciar.TabIndex = 0;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // btFinalizar
            // 
            this.btFinalizar.Location = new System.Drawing.Point(215, 521);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(121, 53);
            this.btFinalizar.TabIndex = 1;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // lbPorta
            // 
            this.lbPorta.AutoSize = true;
            this.lbPorta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPorta.Location = new System.Drawing.Point(74, 464);
            this.lbPorta.Name = "lbPorta";
            this.lbPorta.Size = new System.Drawing.Size(86, 18);
            this.lbPorta.TabIndex = 2;
            this.lbPorta.Text = "Porta COM";
            // 
            // txPorta
            // 
            this.txPorta.Location = new System.Drawing.Point(166, 462);
            this.txPorta.Name = "txPorta";
            this.txPorta.Size = new System.Drawing.Size(100, 20);
            this.txPorta.TabIndex = 3;
            // 
            // thermControl1
            // 
            this.thermControl1.Location = new System.Drawing.Point(104, 12);
            this.thermControl1.MinimumSize = new System.Drawing.Size(180, 315);
            this.thermControl1.Name = "thermControl1";
            this.thermControl1.Size = new System.Drawing.Size(180, 413);
            this.thermControl1.TabIndex = 4;
            this.thermControl1.Value = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 610);
            this.Controls.Add(this.thermControl1);
            this.Controls.Add(this.txPorta);
            this.Controls.Add(this.lbPorta);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.btIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.Label lbPorta;
        private System.Windows.Forms.TextBox txPorta;
        private ThermometerControl.ThermControl thermControl1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

