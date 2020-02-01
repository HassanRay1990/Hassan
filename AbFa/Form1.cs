using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbFa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double MonthLA;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double cubeMeter, days, CityCoe, Units, MonthL, AbBaha, Abonman, KhDFazelab, Maliat, Tabsare, kol;

            cubeMeter = Convert.ToDouble(txtLitr.Text) / 1000;
            days = Convert.ToDouble(txtDays.Text);
            CityCoe = Convert.ToDouble(txtZshahr.Text);
            Units = Convert.ToDouble(txtVahed.Text);

            MonthL = cubeMeter * 30 / days / Units;

            if (MonthL > 0 && MonthL <= 5)
            {
                MonthLA = 1419 * MonthL;
            }
            else if (MonthL > 5 && MonthL <= 10)
            {
                MonthLA = 2123 * MonthL - 3520;
            }
            else if (MonthL > 10 && MonthL <= 15)
            {
                MonthLA = 2827 * MonthL - 10560;
            }
            else if (MonthL > 15 && MonthL <= 20)
            {
                MonthLA = 3703 * MonthL - 23700;
            }
            else if (MonthL > 20 && MonthL <= 25)
            {
                MonthLA = 5400 * MonthL - 57640;
            }
            else if (MonthL > 25 && MonthL <= 30)
            {
                MonthLA = 8496 * MonthL - 135040;
            }
            else if (MonthL > 30 && MonthL <= 35)
            {
                MonthLA = 11580 * MonthL - 227560;
            }
            else if (MonthL > 35 && MonthL <= 40)
            {
                MonthLA = 15444 * MonthL - 362800;
            }
            else if (MonthL > 40 && MonthL <= 50)
            {
                MonthLA = 33462 * MonthL - 1083520;
            }
            else if (MonthL > 50)
            {
                MonthLA = 66924 * MonthL - 2756620;
            }

            AbBaha = MonthLA * Units * days * CityCoe / 30;
            txtAbBaha.Text = Math.Round(AbBaha).ToString();

            Abonman = days * Units * 10000 / 30;
            txtAbonman.Text = Math.Round(Abonman).ToString();
            txtAbonmanF.Text = Math.Round(Abonman).ToString();

            KhDFazelab = AbBaha * 0.7;
            txtFazelab.Text = Math.Round(KhDFazelab).ToString();

            Maliat = (AbBaha + Abonman * 2 + KhDFazelab) * 0.09;
            txtMaliat.Text = Math.Round(Maliat).ToString();

            Tabsare = cubeMeter * 150;
            txtTabsare.Text = Math.Round(Tabsare).ToString();

            kol = AbBaha + Abonman * 2 + KhDFazelab + Maliat + Tabsare;
            txtKol.Text = Math.Round(kol).ToString();

        }
    }
}
