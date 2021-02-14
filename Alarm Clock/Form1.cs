using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerClock.Start();
        }

        private void DisplayTime()
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            DisplayTime();
        }

        private void buttonTurnOn_Click(object sender, EventArgs e)
        {

        }
    }
}
