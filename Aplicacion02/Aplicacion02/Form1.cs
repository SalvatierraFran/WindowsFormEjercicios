using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.txtMonto.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtMonto.Text) > 30 && int.Parse(txtMonto.Text) < 50)
            {
                float Desc = (int.Parse(this.txtMonto.Text) * 10) / 100;
                this.txtDesc.Text = Desc.ToString();

                this.txtTotal.Text = (int.Parse(this.txtMonto.Text) - Desc).ToString();
            }
            else if (int.Parse(this.txtMonto.Text) > 50)
            {
                float Desc = (int.Parse(this.txtMonto.Text) * 20) / 100;
                this.txtDesc.Text = Desc.ToString();

                this.txtTotal.Text = (int.Parse(this.txtMonto.Text) - Desc).ToString();
            }
            else
            {
                this.txtDesc.Text = "0";
                this.txtTotal.Text = this.txtMonto.Text;
            }

            this.txtDesc.ReadOnly = true;
            this.txtTotal.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtMonto.Clear();
            this.txtDesc.Clear();
            this.txtTotal.Clear();

            this.txtDesc.ReadOnly = false;
            this.txtTotal.ReadOnly = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
