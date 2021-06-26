using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_no_Forms
{
    public partial class Form1 : Form
    {
       


        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0, n3 = 0, media = 0;
            n1 = double.Parse(textN1.Text);
            n2 = double.Parse(textN2.Text);
            n3 = Convert.ToDouble(textN3.Text);
            media = (n1 + n2 + n3) / 3;
            lblMedia.Text = textName.Text + ",sua média é : " + Convert.ToString(media);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textName.Clear();
            textN1.Clear();
            textN2.Clear();
            textN3.Clear();
            lblMedia.Text = " ";
        }
    }
}
