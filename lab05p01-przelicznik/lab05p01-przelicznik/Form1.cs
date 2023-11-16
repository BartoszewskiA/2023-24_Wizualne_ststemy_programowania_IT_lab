using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab05p01_przelicznik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            przygotujOkno();
        }

        void przygotujOkno()
        {
            tb_in.Text = 0.ToString();
            tb_out.Text = 0.ToString();
            rb_in_pln.Checked = true;
            rb_ou_euro.Checked = true;
            opisyWalut();
        }

        void opisyWalut()
        {
            if (rb_in_pln.Checked)
                la_in.Text = "PLN";
            else if (rb_in_euro.Checked)
                la_in.Text = "EURO";
            else la_in.Text = "USD";

            if (rb_ou_pln.Checked)
                la_out.Text = "PLN";
            else if (rb_ou_euro.Checked)
                la_out.Text = "EURO";
            else la_out.Text = "USD";
        }

        double przeliczWalute(double zrodlowa)
        {
            double przeliczeniowa_PLN = 0;
            if (rb_in_pln.Checked)
                przeliczeniowa_PLN = zrodlowa;
            else if (rb_in_euro.Checked)
                przeliczeniowa_PLN = zrodlowa * 4.42;
            else
                przeliczeniowa_PLN = zrodlowa * 4.12;

            double wynik = 0;
            if (rb_ou_pln.Checked)
                wynik = przeliczeniowa_PLN;
            else if (rb_ou_euro.Checked)
                wynik = przeliczeniowa_PLN / 4.42;
            else
                wynik = przeliczeniowa_PLN / 4.12;

            wynik = Math.Round(wynik, 2);
            return wynik;
               
        }

        private void rb_in_pln_CheckedChanged(object sender, EventArgs e)
        {
            opisyWalut();
            tb_out.Text = przeliczWalute(Double.Parse(tb_in.Text)).ToString();
        }

        private void rb_in_euro_CheckedChanged(object sender, EventArgs e)
        {
            opisyWalut();
            tb_out.Text = przeliczWalute(Double.Parse(tb_in.Text)).ToString();
        }

        private void rb_in_usd_CheckedChanged(object sender, EventArgs e)
        {
            opisyWalut();
            tb_out.Text = przeliczWalute(Double.Parse(tb_in.Text)).ToString();
        }

        private void rb_ou_pln_CheckedChanged(object sender, EventArgs e)
        {
            opisyWalut();
            tb_out.Text = przeliczWalute(Double.Parse(tb_in.Text)).ToString();
        }

        private void rb_ou_euro_CheckedChanged(object sender, EventArgs e)
        {
            opisyWalut();
            tb_out.Text = przeliczWalute(Double.Parse(tb_in.Text)).ToString();
        }

        private void rb_ou_usd_CheckedChanged(object sender, EventArgs e)
        {
            opisyWalut();
            tb_out.Text = przeliczWalute(Double.Parse(tb_in.Text)).ToString();
        }

        private void hs_in_Scroll(object sender, ScrollEventArgs e)
        {
            double wynik;
            wynik = hs_in.Value / 100.0;
            tb_in.Text = wynik.ToString();
            tb_out.Text = przeliczWalute(Double.Parse(tb_in.Text)).ToString();
        }
    }
}
