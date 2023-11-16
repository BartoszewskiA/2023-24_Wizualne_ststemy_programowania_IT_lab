using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02p01
{
    public partial class Form1 : Form
    {

        int ile = 0; 
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.White;
           zmienKolor();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ile++;
            label1.Text = ile.ToString();
            zmienKolor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ile--;
            label1.Text = ile.ToString();
            zmienKolor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ile=0;
            label1.Text = ile.ToString();
            zmienKolor();
        }

        private void zmienKolor()
        {
            if (ile > 0) label1.ForeColor = Color.Green;
            else if (ile == 0) label1.ForeColor = Color.Black;
            else label1.ForeColor = Color.Red;
        }
    }
}
