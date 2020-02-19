using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notloop六日
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int years = int.Parse(textBox1.Text);
            DateTime startDateTime = new DateTime(int.Parse(textBox1.Text), 1, 1);
            if (DateTime.IsLeapYear(years) && startDateTime.DayOfWeek == DayOfWeek.Sunday)
            {

                label1.Text = $"{years}年有53個星期日,52個星期六";
            }
            else if (DateTime.IsLeapYear(years) && startDateTime.DayOfWeek == DayOfWeek.Saturday)
            {
                label1.Text = $"{years}年有53個星期日,53個星期六";
            }

            else
            { label1.Text = $"{years}年有52個星期日,52個星期六"; }
        }
    }
}
