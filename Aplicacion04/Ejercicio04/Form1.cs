using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.listNum.Items.Add(this.txtNumero.Text);
            this.txtNumero.Clear();
            this.txtNumero.Focus();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (rbtnAsc.Checked == true)
            {
                this.listNum.Sorted = true;
            }

            if (rbtnDesc.Checked == true)
            {
                String[] ordenar = this.listNum.Items.Cast<string>().ToArray();
                Array.Sort(ordenar);
                Array.Reverse(ordenar);

                this.listNum.Items.Clear();

                foreach (string item in ordenar)
                {
                    this.listNum.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
