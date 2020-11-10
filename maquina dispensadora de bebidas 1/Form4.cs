using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BE;
namespace maquina_dispensadora_de_bebidas_1
{
    public partial class Form4 : Form
    {
        System.IO.Ports.SerialPort ArduinoPort;
        bool Isclosed = false;
        public Form4()
        {
           
            
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM16";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.ReadTimeout = 500;
            //todo: mensaje de error, continua el programa si llega a haber error
            try
            {
                ArduinoPort.Open();
            }
            catch 
            {
                
            }
        }
        public StockGeneral Comparador = new StockGeneral();

        private void Form4_Load(object sender, EventArgs e)
        {
            Thread Hilo = new Thread(EscucharSerial);
            Hilo.Start();
        }
        public void EscucharSerial()
        {
             while (!Isclosed)
            try
            {
                    string cadena = ArduinoPort.ReadLine().Trim();

                    
                    txtInfo.Invoke(new MethodInvoker(
                    delegate
                       {
                           //aca mostramos si el codigo uid es correcto en ves de arduino


                           txtInfo.Text = Comparador.Valid(cadena);
                           
                          
                          

                       }

                    ));

            }
            catch { }
        }

         private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Isclosed = true;
            if (ArduinoPort.IsOpen)
                ArduinoPort.Close();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            ArduinoPort.Close();
            Form2 f2 = new Form2();
            f2.Show();
            this.Close(); //cierra el formulario
            this.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArduinoPort.Close();
            Form1 f1 = new Form1();
            f1.Show();
            this.Close(); //cierra el formulario
            this.Dispose();
            //Visible = false;
        }
    }
}
