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
    public partial class Form_Ex2 : Form
    {
        public Form_Ex2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtValor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(TxtValor.Text);

                LblDiv2.Visible = num % 2 == 0;
                LblDiv5.Visible = num % 5 == 0;
                LblDiv10.Visible = num % 10 == 0;
            }
            catch
            {
                TxtValor.Text = "";
            }
        }
    }
}
