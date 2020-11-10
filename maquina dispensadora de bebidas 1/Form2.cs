using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
namespace maquina_dispensadora_de_bebidas_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        
        }
        public StockGeneral StockActual = new StockGeneral();
        





        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Visible = true;
            //this.Close(); //cierra el formulario
            //this.Dispose();
            Visible = false;
        }

        public void label2_Click(object sender, EventArgs e)
        {
            //label2.Text = System.Convert.ToString(StockActual.tabla.Rows[0]["cantidad"] + " en stock");

        }

        public void Form2_Load(object sender, EventArgs e)
        {
            //StockActual.Coca = 0;
        //label2.Text = System.Convert.ToString(StockActual.tabla.Rows[0]["cantidad"] + " en stock");
           // label3.Text = System.Convert.ToString(StockActual.Fanta + " en stock");
        }
    }
}
