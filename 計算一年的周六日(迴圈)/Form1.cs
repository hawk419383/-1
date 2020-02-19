using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算一年的周六日_迴圈_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = int.Parse(textBox1.Text);
            int daysinyear = 0;
            
            int FS = 0;
            int FSUN = 0;
            for (int i = 1; i < 13; i++)//算天數
            {
                int daysofyear = DateTime.DaysInMonth(year, i);
                daysinyear +=  daysofyear;
            }
            for(int i = 1; i < 8; i++) 
            {
                DateTime firstday = new DateTime(year, 1, i);
                if(firstday.DayOfWeek == DayOfWeek.Saturday) 
                { FS = daysinyear - i; }
                else if(firstday.DayOfWeek == DayOfWeek.Sunday)
                { FSUN = daysinyear - i; }
            }
            int SOF = (FS+7) / 7;
            int SUNOF = (FSUN + 7) / 7;
          
            label1.Text = $" 有{SOF}星期六,有{SUNOF}星期日";
        }
    }
}
