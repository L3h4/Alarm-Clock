using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Alarm_Clock
{
    public partial class Form1 : Form
    {
        int H, M;
        int h, m, s;
        DateTime current;
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
            current = DateTime.Now;
            h = current.Hour;
            m = current.Minute;
            s = current.Second;

             if (h == H && m == M && s == 0)
            {
                MessageBox.Show("Alarm", "Alarm");
                string path = Path.GetFullPath(@"..\..\Sounds\Sound_23479.mp3");
                MediaPlayer.URL = path;
                MediaPlayer.Ctlcontrols.play();
            }
        }

        private void buttonTurnOn_Click(object sender, EventArgs e)
        {
            H = (int)numericUpDown1.Value;
            M = (int)numericUpDown2.Value;

        }
    }
}
