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
    public partial class Form_Ex1 : Form
    {
        public Form_Ex1()
        {
            InitializeComponent();
        }
        private void BtnCalcularEX1_Click(object sender, EventArgs e)
        {
            int v1 = 0, v2 = 0, R = 0;

            v1 = int.Parse(TxtBoxVal1EX1.Text);
            v2 = int.Parse(TxtBoxVal2EX1.Text);

            R = v1 + v2;

            if (R > 20)
            {
                LblResultEX1.Text = Convert.ToString(R + 8);
                LblResultEX1.Text = "Resultado + 8 = " + LblResultEX1.Text;

            }
            else if (R <= 20) 
            {
                LblResultEX1.Text = Convert.ToString(R - 5);
                LblResultEX1.Text = "Resultado - 5 = " + LblResultEX1.Text;
            }
        }
    }
}
