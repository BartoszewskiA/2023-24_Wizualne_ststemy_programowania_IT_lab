using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03p01
{
    public partial class Form1 : Form
    {
        Color kolor_powrotu;
        Random rand;
        int pulapka;
        public Form1()
        {
            InitializeComponent();
            kolor_powrotu = panel1.BackColor;
            rand = new Random();
            pulapka=  rand.Next(4)+1;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            if(pulapka==1)
            panel1.BackColor = Color.Red;
        }

        void reset()
        {
            panel1.BackColor = kolor_powrotu;
            panel2.BackColor = kolor_powrotu;
            panel3.BackColor = kolor_powrotu;
            panel4.BackColor = kolor_powrotu;
            pulapka = rand.Next(4) + 1;

        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            reset();
        }

        private void panel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            reset();
        }

        private void panel4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            reset();
        }

        private void panel3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            reset();
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            if (pulapka == 2)
                panel2.BackColor = Color.Red;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            if (pulapka == 3)
                panel3.BackColor = Color.Red;
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            if (pulapka == 4)
                panel4.BackColor = Color.Red;
        }
    }
}
