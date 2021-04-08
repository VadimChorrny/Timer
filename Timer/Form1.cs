using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_
{
    public partial class Form1 : Form
    {
        public DateTime data = new DateTime();
        Timer timer = new Timer();
        public bool state = false;
        public Stopwatch sw = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            long tick = DateTime.Now.Ticks - data.Ticks;
            DateTime stopWatch = new DateTime();
            stopWatch = stopWatch.AddTicks(tick);
            label1.Text = String.Format("{0:HH:mm:ss:ff}", stopWatch);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!state)
            {
                data = DateTime.Now;
                timer.Interval = 10;
                timer.Tick += new EventHandler(label1_Click);
                timer.Start();
                state = true;
            }
            else
            {
                data = DateTime.Now;
                timer.Stop();
                state = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string id = (string)textBox1.Text;
            if (id.Length <= 3)
            {
                label2.Text = id;
            }
            else
            {
                label2.Text = "Your ID very big!";
            }
            //id += new EventHandler(label3_Click);
        }

        private void label2_Click_1(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string gold = (string)textBox2.Text;
            label4.Text = gold;
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    data = DateTime.Now;
        //    timer.Stop();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    data = DateTime.Now;
        //    timer.Interval = 10;
        //    timer.Tick += new EventHandler(label1_Click);
        //    timer.Start();
        //}
    }
}
