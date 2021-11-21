using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTask3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtInputSecond.Text);

            int h = n / 3600;
            int m = (n % 3600) / 60;
            int s = (n % 3600) - (m * 60);

            lblHourOutput.Text = h.ToString();
            lblMinutesOutput.Text = m.ToString();
            lblSecondOutput.Text = s.ToString();


        }
    }
}