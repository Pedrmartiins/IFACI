namespace Temp_arduino
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
            this.bt_iniciar = new System.Windows.Forms.Button();
            this.bt_finalizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txporta = new System.Windows.Forms.TextBox();
            this.thermControl1 = new ThermometerControl.ThermControl();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // bt_iniciar
            // 
            this.bt_iniciar.Location = new System.Drawing.Point(49, 611);
            this.bt_iniciar.Name = "bt_iniciar";
            this.bt_iniciar.Size = new System.Drawing.Size(119, 58);
            this.bt_iniciar.TabIndex = 1;
            this.bt_iniciar.Text = "&INICIAR";
            this.bt_iniciar.UseVisualStyleBackColor = true;
            this.bt_iniciar.Click += new System.EventHandler(this.bt_iniciar_Click);
            // 
            // bt_finalizar
            // 
            this.bt_finalizar.Location = new System.Drawing.Point(210, 611);
            this.bt_finalizar.Name = "bt_finalizar";
            this.bt_finalizar.Size = new System.Drawing.Size(119, 58);
            this.bt_finalizar.TabIndex = 1;
            this.bt_finalizar.Text = "Finalizar";
            this.bt_finalizar.UseVisualStyleBackColor = true;
            this.bt_finalizar.Click += new System.EventHandler(this.bt_finalizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 559);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PORTA COM";
            // 
            // txporta
            // 
            this.txporta.Location = new System.Drawing.Point(229, 552);
            this.txporta.Name = "txporta";
            this.txporta.Size = new System.Drawing.Size(100, 20);
            this.txporta.TabIndex = 3;
            // 
            // thermControl1
            // 
            this.thermControl1.Location = new System.Drawing.Point(99, 92);
            this.thermControl1.MinimumSize = new System.Drawing.Size(180, 315);
            this.thermControl1.Name = "thermControl1";
            this.thermControl1.Size = new System.Drawing.Size(180, 409);
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
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(373, 706);
            this.Controls.Add(this.thermControl1);
            this.Controls.Add(this.txporta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_finalizar);
            this.Controls.Add(this.bt_iniciar);
            this.Name = "Form1";
            this.Text = "Termometro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_iniciar;
        private System.Windows.Forms.Button bt_finalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txporta;
        private ThermometerControl.ThermControl thermControl1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

