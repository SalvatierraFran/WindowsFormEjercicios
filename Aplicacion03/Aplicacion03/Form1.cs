using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion03
{
    public partial class    Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtCadena.Clear();
            this.txtInvertida.Clear();
            this.txtAlfa.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = this.txtCadena.Text;
            string OrdenAlfa = "";

            for (int i = cadena.Length -1; i >= 0; i--)
            {
                this.txtInvertida.Text += cadena[i];
            }

            char[] Ordena = this.txtCadena.Text.ToCharArray();
            Array.Sort(Ordena);

            for (int i = 0; i < Ordena.Length; i++)
            {
                this.txtAlfa.Text += Ordena[i].ToString();
            }

            /*foreach (char item in Ordena)
            {
                OrdenAlfa += item;
            }

            this.txtAlfa.Text = OrdenAlfa;*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
