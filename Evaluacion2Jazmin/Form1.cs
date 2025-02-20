using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion2Jazmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double teo1, teo2, teo3, lab4, lab5, lab6;
        double Promedio;

        private void button1_Click(object sender, EventArgs e)
        {
            teo1 = Convert.ToInt32(Teo1.Text);
            teo2 = Convert.ToInt32(Teo2.Text);
            teo3 = Convert.ToInt32(Teo3.Text);
            lab4 = Convert.ToInt32(Lab4.Text);
            lab5 = Convert.ToInt32(Lab5.Text);
            lab6 = Convert.ToInt32(Lab6.Text);
            Promedio = (teo1 + teo2 + teo3 + lab4 + lab5 + lab6) / 6;
            Prom.Text = Promedio.ToString();

            if (Promedio >= 8 && Promedio <= 10)
            {
                A.Text = "APROBADO".ToString();
                consejo.Text = "Muy buen trabajo, va en un buen camino.".ToString();
                pictureBox1.Image = Properties.Resources.exelente;
                pictureBox1.Visible = true;
            }

            else if (Promedio >= 7 && Promedio <= 7.99)
            {
                A.Text = "APROBADO".ToString();
                consejo.Text = "Muy bien pero de mas de usted. ".ToString();
                pictureBox1.Image = Properties.Resources.bien;
                pictureBox1.Visible = true;
            }

            else if (Promedio >= 3 && Promedio <= 6.99)
            {
                A.Text = "REPROBADO".ToString();
                consejo.Text = "Como que quiere ir amando el INDEL...".ToString();
                pictureBox1.Image = Properties.Resources.no;
                pictureBox1.Visible = true;
            }

            else if (Promedio >=2.99)
            {
                A.Text = "REPROBADO".ToString();
                consejo.Text = "Siga asi y veterano del INDEL sera.".ToString();
                pictureBox1.Image = Properties.Resources.mal;
                pictureBox1.Visible = true;
            }
        }
    }
}
