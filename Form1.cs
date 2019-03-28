using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kronometre_yaptım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int second,minute,hour;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            label3.Text = Convert.ToString(second);
            if (second==60)
            {
                second = 0;
                minute++;
                label1.Text=Convert.ToString(minute);
            }
            if (minute==60)
            {
                minute = 0;
                hour++;
                label2.Text = Convert.ToString(hour);
            }
        }
    }
}
