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
    public partial class Form_Ex4 : Form
    {
        public Form_Ex4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (List.SelectedIndex == 0) { lblMes.Text = "Janeiro"; }
            else if (List.SelectedIndex == 1) { lblMes.Text = "Fevereiro"; }
            else if (List.SelectedIndex == 2) { lblMes.Text = "Março"; }
            else if (List.SelectedIndex == 3) { lblMes.Text = "Abril"; }
            else if (List.SelectedIndex == 4) { lblMes.Text = "Maio"; }
            else if (List.SelectedIndex == 5) { lblMes.Text = "Junho"; }
            else if (List.SelectedIndex == 6) { lblMes.Text = "Julho"; }
            else if (List.SelectedIndex == 7) { lblMes.Text = "Agosto"; }
            else if (List.SelectedIndex == 8) { lblMes.Text = "Setembro"; }
            else if (List.SelectedIndex == 9) { lblMes.Text = "Outubro"; }
            else if (List.SelectedIndex == 10) { lblMes.Text = "Novembro"; }
            else if (List.SelectedIndex == 11) { lblMes.Text = "Dezembro"; }
        }
    }
}
