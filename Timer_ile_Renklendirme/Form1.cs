using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_ile_Renklendirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saniye = 0;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\Timer_ile_Renklendirme\\fbmars.mp3";
            chkbGS.Checked = false;
            chkbBJK.Checked = false;
            chkbTS.Checked = false;
        }
        private void chkbGS_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\Timer_ile_Renklendirme\\gsmars.mp3";
            chkbFB.Checked = false;
            chkbBJK.Checked = false;
            chkbTS.Checked = false;
        }
        private void chkbBJK_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\Timer_ile_Renklendirme\\bjkmars.mp3";
            chkbFB.Checked = false;
            chkbGS.Checked = false;
            chkbTS.Checked = false;
        }
        private void chkbTS_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\Timer_ile_Renklendirme\\tsmars.mp3";
            chkbFB.Checked = false;
            chkbGS.Checked = false;
            chkbBJK.Checked = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye = Convert.ToInt32(lblTimer.Text);
            saniye++;
            lblTimer.Text = saniye.ToString();

            if (chkbFB.Checked == true)
            {
                if (saniye % 10 == 0)
                {
                    button1.BackColor = Color.Blue;
                    button2.BackColor = Color.Yellow;
                    button3.BackColor = Color.Blue;
                    button4.BackColor = Color.Yellow;
                    button5.BackColor = Color.Yellow;
                    button6.BackColor = Color.Blue;
                    button7.BackColor = Color.Yellow;
                    button8.BackColor = Color.Blue;
                }
                if (saniye % 10 == 5)
                {
                    button1.BackColor = Color.Yellow;
                    button2.BackColor = Color.Blue;
                    button3.BackColor = Color.Yellow;
                    button4.BackColor = Color.Blue;
                    button5.BackColor = Color.Blue;
                    button6.BackColor = Color.Yellow;
                    button7.BackColor = Color.Blue;
                    button8.BackColor = Color.Yellow;
                }
            }
            if (chkbGS.Checked == true)
            {
                if (saniye % 10 == 0)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Yellow;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Yellow;
                    button5.BackColor = Color.Yellow;
                    button6.BackColor = Color.Red;
                    button7.BackColor = Color.Yellow;
                    button8.BackColor = Color.Red;
                }
                if (saniye % 10 == 5)
                {
                    button1.BackColor = Color.Yellow;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Yellow;
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Yellow;
                    button7.BackColor = Color.Red;
                    button8.BackColor = Color.Yellow;
                }
            }
            if (chkbBJK.Checked == true)
            {
                if (saniye % 10 == 0)
                {
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.White;
                    button5.BackColor = Color.White;
                    button6.BackColor = Color.Black;
                    button7.BackColor = Color.White;
                    button8.BackColor = Color.Black;
                }
                if (saniye % 10 == 5)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.Black;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.Black;
                    button5.BackColor = Color.Black;
                    button6.BackColor = Color.White;
                    button7.BackColor = Color.Black;
                    button8.BackColor = Color.White;
                }
            }
            if (chkbTS.Checked == true)
            {
                if (saniye % 10 == 0)
                {
                    button1.BackColor = Color.Blue;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Blue;
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Blue;
                    button7.BackColor = Color.Red;
                    button8.BackColor = Color.Blue;
                }
                if (saniye % 10 == 5)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Blue;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Blue;
                    button5.BackColor = Color.Blue;
                    button6.BackColor = Color.Red;
                    button7.BackColor = Color.Blue;
                    button8.BackColor = Color.Red;
                }
            }
        }
    }
}
