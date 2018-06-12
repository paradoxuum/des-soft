using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex05062018
{
    public partial class Form_Ex7 : Form
    {
        public Form_Ex7()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        
        {

            double  a = 2, m = 3,
                    al1 = double.Parse(TxtBoxArlindo.Text), 
                    al2 = double.Parse(TxtBoxManoel.Text);

            int i = 0, conta = 0;

            while (i < 1)
            {
                double resultalt1 = al1 + a;
                a = a + 2;
                double resultalt2 = al2 + m;
                m = m + 3;
                conta++;

                if (resultalt1 < resultalt2)
                {
                    TxtBoxResult.Text = "Manoel será maior que Arlindo em: " + conta + " Ano(s)";
                    break;
                }

            }

        }
    }
}
