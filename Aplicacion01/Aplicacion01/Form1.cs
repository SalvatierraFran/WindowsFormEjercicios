using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rdo;
            string muestreo;

            for (int i = 1; i <= 10; i++)
            {
                rdo = int.Parse(this.txtNumero.Text) * i;
                muestreo = int.Parse(this.txtNumero.Text).ToString() + " * " + i.ToString() + " = " + rdo.ToString();
                this.lstTabla.Items.Add(muestreo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtNumero.Clear();
            this.lstTabla.Items.Clear();
        }
    }
}
