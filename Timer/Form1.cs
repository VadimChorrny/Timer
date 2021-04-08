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
            data = DateTime.Now;
            timer.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data = DateTime.Now;
            timer.Interval = 10;
            timer.Tick += new EventHandler(label1_Click);
            timer.Start();
        }
    }
}
