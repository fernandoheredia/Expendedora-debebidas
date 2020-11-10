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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            Form2 f2 = new Form2();
            f2.Visible = true;
            
            //this.Close();
            //this.Dispose();
            Visible = false;
            
        }
    }
}
