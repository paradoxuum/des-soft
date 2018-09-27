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
                float ladoA = float.Parse(TxtBox1.Text);
                float ladoB = float.Parse(TxtBox2.Text);
                float ladoC = float.Parse(TxtBox3.Text);

                if (ladoA == ladoB && ladoB == ladoC && ladoC == ladoA)
                {
                    Result.Text = "Triangulo Equilátero";
                }
                else if (ladoA == ladoB || ladoB == ladoC || ladoC == ladoA)
                {
                    Result.Text = "Triangulo Isósceles";
                }
                else
                {
                    Result.Text = "Triangulo Escaleno";
                }
            }
            catch {
                Result.Text = "Deu um Erro inesperado";
            }

        }

        private void Form_Ex3_Load(object sender, EventArgs e)
        {

        }
    }
}
