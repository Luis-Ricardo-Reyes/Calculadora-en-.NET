using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            label_respuesta.Text = Int64.Parse( numero_1.Text) + Int64.Parse(numero_2.Text) +"";
        }

        private void restar_Click(object sender, EventArgs e)
        {
            label_respuesta.Text = Int64.Parse(numero_1.Text) - Int64.Parse(numero_2.Text) + "";
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            label_respuesta.Text = Int64.Parse(numero_1.Text) * Int64.Parse(numero_2.Text) + "";
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            label_respuesta.Text = Int64.Parse(numero_1.Text) / Int64.Parse(numero_2.Text) + "";
        }
    }
}
