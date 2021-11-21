using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTask2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int week = 0; 
            week = int.Parse(txtWeek.Text);
            int month = 0; 
            month = int.Parse(txtMonth.Text);
            int year = 0;
            year = int.Parse(txtYear.Text);
            
            lblOuptut.Text = $"{(week * 7) + (month * 30) + (year * 365) }";
            

        }
    }
}
