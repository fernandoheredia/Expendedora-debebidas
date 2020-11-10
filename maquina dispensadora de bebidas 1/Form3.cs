using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maquina_dispensadora_de_bebidas_1
{
    public partial class Form3 : Form
    {
         


        public Form3()
        {
            InitializeComponent();
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        

        private void button11_Click(object sender, EventArgs e)
        {
            int PrecioCocacola = 55;
            int PrecioTotal;
            int Text1;
            int Text2;
            Text1 = int.Parse(textBox1.Text);
            //Text2 = Text1;
            Text2 = Text1 * PrecioCocacola;
            textBox2.Text ="$" + Text2.ToString();
            
            
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //todo:Condicion Para El Pagar: "Aun Sin Terminar"!!
            //if (System.Convert.ToInt32(textBox1.Text) < 1)
           // {

           // }
           // else
            {


               // Form2.StockActual.Coca = stockGeneral.Coca - System.Convert.ToInt32(textBox1.Text);
                

                Form4 f4 = new Form4();
                f4.Show();
                this.Close();
                //Visible = false;
            }
        }

        public void button15_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Visible = true;
            this.Close(); //cierra el formulario
            this.Dispose();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Visible = true;
            this.Close(); //cierra el formulario
            this.Dispose();
        }

        

        
    }
}
