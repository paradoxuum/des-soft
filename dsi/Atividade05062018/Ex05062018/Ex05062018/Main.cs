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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void MenuItemEX1_Click(object sender, EventArgs e)
        {
            Form_Ex1 Ex1 = new Form_Ex1();
            Ex1.MdiParent = this;
            Ex1.Show();
        }
        private void MenuItemEX2_Click(object sender, EventArgs e)
        {
            Form_Ex2 Ex2 = new Form_Ex2();
            Ex2.MdiParent = this;
            Ex2.Show();
        }
        private void MenuItemEX3_Click(object sender, EventArgs e)
        {
            Form_Ex3 Ex3 = new Form_Ex3();
            Ex3.MdiParent = this;
            Ex3.Show();
        }
        private void MenuItemEX4_Click(object sender, EventArgs e)
        {
            Form_Ex4 Ex4 = new Form_Ex4();
            Ex4.MdiParent = this;
            Ex4.Show();
        }
        private void MenuItemEX5_Click(object sender, EventArgs e)
        {
            Form_Ex5 Ex5 = new Form_Ex5();
            Ex5.MdiParent = this;
            Ex5.Show();
        }
        private void MenuItemEX6_Click(object sender, EventArgs e)
        {
            
        }
        private void MenuItemEX7_Click(object sender, EventArgs e)
        {
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        
        }

        private void BtnCalcularEX1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
