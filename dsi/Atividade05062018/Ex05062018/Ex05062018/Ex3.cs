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
    public partial class Form_Ex3 : Form
    {
        public Form_Ex3()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int l1 = int.Parse(lblValor1.Text);
                int l2 = int.Parse(lblValor2.Text);
                int l3 = int.Parse(lblValor3.Text);

                if (l1 == l2 && l2 == l3)
                {
                    Result.Text = "Equilátero";
                }
                else if (l1 == l2 || l1 == l3 || l2 == l3)
                {
                    Result.Text = "Isósceles";
                }
                else
                {
                    Result.Text = "Escaleno";
                }
            }
            catch
            {
                lblValor1.Text = "";
                lblValor1.Text = "";
                lblValor1.Text = "";
                Result.Text = "ERRO";
            }
        }
    }
}
