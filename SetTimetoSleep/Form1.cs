using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.CoreAudioApi;



namespace SetTimetoSleep
{
    public partial class Form1 : Form
    {
        private MMDevice defaultdevice = null;
        private int countdownT;
        private float iniVol;
        private int iniCount;
        public Form1()
        {
            InitializeComponent();
            MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
            defaultdevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            ShowSystemTimeTimer.Enabled = true;
            label1.Text = System.DateTime.Now.ToString("yyyy-MM-dd  HH:mm");
        }

      
        private void ShowSystemTimeTimer_Tick(object sender, EventArgs e)
        {
            label1.Text = System.DateTime.Now.ToString("yyyy-MM-dd  HH:mm");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //defaultdevice.AudioEndpointVolume.Mute = true;
            //defaultdevice.AudioEndpointVolume.MasterVolumeLevelScalar = 0.1f;
            button1.Enabled = false;
            button2.Enabled = false;
            if (Convert.ToInt32(FixTimeM.Text) > 60)
            {
                return;
            }
            
            FixTime.Enabled = true;
            FixTime.Interval = 1000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CountDownM.Text) == 0 && Convert.ToInt32(CountDownH.Text) == 0)
            {
                MessageBox.Show("最小倒數時間為1分鐘以上");
                return;
            }
            button1.Enabled = false;
            button2.Enabled = false;            
            iniVol = defaultdevice.AudioEndpointVolume.MasterVolumeLevelScalar;
            Countdown.Enabled = true;
            Countdown.Interval = 1000;
            countdownT = Convert.ToInt32(CountDownM.Text) * 60 + Convert.ToInt32(CountDownH.Text) * 60 * 60;
            iniCount = countdownT;
            CountdownLabel.Text = "倒數:" +
                (countdownT / 3600).ToString() + "小時" +
                ((countdownT % 3600) / 60).ToString() + "分" +
                (countdownT % 60).ToString() + "秒";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            programReset();
        }
        private void programReset()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            FixTime.Enabled = false;
            Countdown.Enabled = false;
            CountdownLabel.Text = "倒數:";
        }

        private void FixTime_Tick(object sender, EventArgs e)
        {
            string tmpH = System.DateTime.Now.ToString("HH");
            string tmpM = System.DateTime.Now.ToString("mm");
            if (FixTimeH.Text == tmpH  && FixTimeM.Text == tmpM )
            {
                defaultdevice.AudioEndpointVolume.Mute = true;
                MessageBox.Show("Time to sleep ^___^");
                programReset();
            }
        }

        private void Countdown_Tick(object sender, EventArgs e)
        {
            countdownT--;
            CountdownLabel.Text = "倒數:" +
                (countdownT / 3600).ToString()+ "小時"+
                ((countdownT %3600)/60).ToString() + "分" + 
                (countdownT % 60).ToString() + "秒";
            if (countdownT > 10)
            {
                defaultdevice.AudioEndpointVolume.MasterVolumeLevelScalar = iniVol * ((float)countdownT / (float)iniCount);
            }
            
            if (countdownT == 0)
            {
                defaultdevice.AudioEndpointVolume.Mute = true;
                MessageBox.Show("Time to sleep ^___^");
                programReset();
            }
        }

        private void FixTimeH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else{
                e.Handled = true;
            }
        }

        private void FixTimeM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
