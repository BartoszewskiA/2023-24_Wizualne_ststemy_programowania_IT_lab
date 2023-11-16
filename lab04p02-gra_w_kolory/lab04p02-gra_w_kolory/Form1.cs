using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04p02_gra_w_kolory
{
    public partial class Form1 : Form
    {

        const int CZAS_GRY = 30;
        
        String[] nazwy_kolorow = new String[] { "Zielony",
                                                "Niebieski",
                                                "Czerwony",
                                                "Żółty"};

        Color[] barwy = new Color[] {   Color.Green,
                                        Color.Blue,
                                        Color.Red,
                                        Color.Yellow};
        int aktualny_kolor = 0;
        int punkty = 0;
        int pozostaly_czas = CZAS_GRY;
        Random random;

        public Form1()
        {
            InitializeComponent();
            gra_zastopowana();
            progressBar1.Maximum = CZAS_GRY;
            progressBar1.Value = CZAS_GRY;
            label1.BackColor = Color.LightGray;
            random = new Random();
            wylosuj_aktualny_kolor();
        }

        void wylosuj_aktualny_kolor()
        {
            aktualny_kolor = random.Next(4);
            int kolor_napisu = random.Next(4);
            label1.Text = nazwy_kolorow[aktualny_kolor];
            label1.ForeColor = barwy[kolor_napisu];
        }

        void reakcja_na_klikniecie(int nr)
        {
            if (nr == aktualny_kolor)
            {
                punkty++;
                label2.Text = punkty.ToString();
                wylosuj_aktualny_kolor();
                if (checkBox1.Checked)
                {
                    timer2.Stop();
                    timer2.Start();
                }
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            reakcja_na_klikniecie(0);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            reakcja_na_klikniecie(1);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            reakcja_na_klikniecie(2);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            reakcja_na_klikniecie(3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pozostaly_czas > 0)
            {
                pozostaly_czas--;
                progressBar1.Value = pozostaly_czas;
            }
            else
            { 
                timer1.Stop();
                timer2.Stop();
                gra_zastopowana();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
            gra_dzilajaca();
            pozostaly_czas = CZAS_GRY;
            progressBar1.Value = CZAS_GRY;
            label2.Text = punkty.ToString();
        }

        void gra_zastopowana()
        {
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            panel1.BackColor = Color.LightGray;
            panel2.BackColor = Color.LightGray;
            panel3.BackColor = Color.LightGray;
            panel4.BackColor = Color.LightGray;
            punkty = 0;
            checkBox1.Enabled = true;

        }
        void gra_dzilajaca()
        {
            panel1.Enabled = true;
            panel2.Enabled = true;
            panel3.Enabled = true;
            panel4.Enabled = true;
            panel1.BackColor = barwy[0];
            panel2.BackColor = barwy[1];
            panel3.BackColor = barwy[2];
            panel4.BackColor = barwy[3];
            checkBox1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            wylosuj_aktualny_kolor();
        }
    }
}
