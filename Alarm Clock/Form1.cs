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
        int AlarmH, AlarmM;
        int TimerSecs;
        bool TimerRuns;
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

        private void bStartTimer_Click(object sender, EventArgs e)
        {
            TimerRuns = !TimerRuns;
            if(TimerRuns)
            {
                bStartTimer.Text = "Stop";
                nUDHours.Visible = false;
                nUDMinutes.Visible = false;
                nUDSeconds.Visible = false;
                lTimerDisp.Visible = true;
                TimerSecs = (int)(nUDHours.Value * 3600 + nUDMinutes.Value * 60 + nUDSeconds.Value);
            }
            else
            {
                lTimerDisp.Text = "00:00:00";
                bStartTimer.Text = "Start";
                nUDHours.Visible = true;
                nUDMinutes.Visible = true;
                nUDSeconds.Visible = true;
                lTimerDisp.Visible = false;
            }

        }

        private void DisplayTime()
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        void timerClock_Tick(object sender, EventArgs e)
        {
            DisplayTime();
            current = DateTime.Now;
            h = current.Hour;
            m = current.Minute;
            s = current.Second;

            if (h == AlarmH && m == AlarmM && s == 0)
            {
            Task.Run(() => { MessageBox.Show("Alarm", "Alarm"); });
            string path = Path.GetFullPath(@"..\..\Sounds\Sound_23479.mp3");
            MediaPlayer.URL = path;
            MediaPlayer.Ctlcontrols.play();
            }
            if(TimerRuns)
            {
                TimerSecs--;
                DistlayTimeLeft();
                if(TimerSecs <= 0)
                {
                    bStartTimer.PerformClick();
                    Task.Run(() => { MessageBox.Show("Timer ran out", "Timer"); });
                    string path = Path.GetFullPath(@"..\..\Sounds\Sound_23479.mp3");
                    MediaPlayer.URL = path;
                    MediaPlayer.Ctlcontrols.play();
                }
            }
        }

        private void DistlayTimeLeft()
        {
            int h, m, s;
            h = (int)TimerSecs / 3600;
            m = (int)((TimerSecs % 3600) / 60);
            s = (int)((TimerSecs % 3600) % 60);
            lTimerDisp.Text = $"{h.ToString("D2")}:{m.ToString("D2")}:{s.ToString("D2")}";
        }

        private void buttonTurnOn_Click(object sender, EventArgs e)
        {
            AlarmH = (int)numericUpDown1.Value;
            AlarmM = (int)numericUpDown2.Value;

        }
    }
}
