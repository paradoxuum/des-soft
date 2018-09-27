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
    public partial class Form_Ex6 : Form
    {
        public Form_Ex6()
        {
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            List.Items.Clear();

            try
            {
                for (int i = 1; i <= int.Parse(TxtBoxNum.Text); i++)
                {
                    List.Items.Add("BRASIL!!!");
                }
            }
            catch
            {
                List.Items.Add("Valor inválido");
            }
        }
    }
}
