using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace rqMtx
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            HWID = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value; //Changing the variable "HWID (String)" to the WindowsIdentity Value, you can use any other forms of HWID, you can even use MAC/IP (Not recommended)
            textBox1.Text = HWID;
            textBox1.ReadOnly = true;
            checkServers();
            int PID = meme.GetProcIdFromName("rqmain");// Check UPD git
            if (PID > 0)
            {
                meme.OpenProcess(PID);
            }
        }

        Mem meme = new Mem();

        string HWID;
       
        //Address List
        string ptrSuit = "rqmain.exe+0x006C2AA8,34,0,1DC,4,8a8";
        string ptrJewel = "rqmain.exe+0x006C2AA8,34,0,1DC,4,380";
        string ptrName = "rqmain.exe+0x7E9368,4,168";
        Point lastPoint;
        public Form1()
        {
            InitializeComponent();
        }
        string srvl = "https://greystonsoft.000webhostapp.com/index.txt";


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // suit male list
        {
            WebClient wb = new WebClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            string HWIDLIST = wb.DownloadString(srvl); //Replace "HWID List URL" with your own URL to a RAW text (txt) file with all your wanted HWIDs [Example: http://myurl.com/HWID.txt]
            if (HWIDLIST.Contains(textBox1.Text))
            {

            }
            else

            {
                System.Windows.Forms.Application.Exit();
            }
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = rqMtx.Properties.Resources.b_default1;
                    meme.WriteMemory(ptrSuit, "Int", "0"); // Убрать костюм
                    break;
                case 1:
                    pictureBox1.Image = rqMtx.Properties.Resources.b_savage;
                    meme.WriteMemory(ptrSuit, "Int", "1760"); // Костюм Варвара
                    break;
                case 2:
                    pictureBox1.Image = rqMtx.Properties.Resources.b_exso;
                    meme.WriteMemory(ptrSuit, "Int", "4273"); // Костюм Экзомеханиста
                    break;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) // suit female list
        {
            WebClient wb = new WebClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            string HWIDLIST = wb.DownloadString(srvl); //Replace "HWID List URL" with your own URL to a RAW text (txt) file with all your wanted HWIDs [Example: http://myurl.com/HWID.txt]
            if (HWIDLIST.Contains(textBox1.Text))
            {

            }
            else

            {
                System.Windows.Forms.Application.Exit();
            }
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = rqMtx.Properties.Resources.g_default;
                    meme.WriteMemory(ptrSuit, "Int", "0"); 
                    break;
                case 1:
                    pictureBox1.Image = rqMtx.Properties.Resources.g_cat;
                    meme.WriteMemory(ptrSuit, "Int", "3047");
                    break;
                case 2:
                    pictureBox1.Image = rqMtx.Properties.Resources.g_exso;
                    meme.WriteMemory(ptrSuit, "Int", "4267");
                    break;

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) // jewel list
        {
            WebClient wb = new WebClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            string HWIDLIST = wb.DownloadString(srvl); //Replace "HWID List URL" with your own URL to a RAW text (txt) file with all your wanted HWIDs [Example: http://myurl.com/HWID.txt]
            if (HWIDLIST.Contains(textBox1.Text))
            {

            }
            else

            {
                System.Windows.Forms.Application.Exit();
            }
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    meme.WriteMemory(ptrJewel, "Int", "0");
                    break;
                case 1:
                    meme.WriteMemory(ptrJewel, "Int", "2036");// Печать Морры
                    break;
                case 2:
                    meme.WriteMemory(ptrJewel, "Int", "1152");// Длань Света
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // nick name button
        {
            WebClient wb = new WebClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            string HWIDLIST = wb.DownloadString(srvl); //Replace "HWID List URL" with your own URL to a RAW text (txt) file with all your wanted HWIDs [Example: http://myurl.com/HWID.txt]
            if (HWIDLIST.Contains(textBox1.Text))
            {

            }
            else

            {
                System.Windows.Forms.Application.Exit();
            }
            if (checkBox1.Checked)
            {
                meme.WriteMemory(ptrName, "String", "NickName");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) // Male button
        {
            WebClient wb = new WebClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            string HWIDLIST = wb.DownloadString(srvl); //Replace "HWID List URL" with your own URL to a RAW text (txt) file with all your wanted HWIDs [Example: http://myurl.com/HWID.txt]
            if (HWIDLIST.Contains(textBox1.Text))
            {

            }
            else

            {
                System.Windows.Forms.Application.Exit();
            }
            pictureBox2.Image = rqMtx.Properties.Resources.char_boy_en;
            pictureBox3.Image = rqMtx.Properties.Resources.char_girl;
            pictureBox1.Image = rqMtx.Properties.Resources.b_default1;
            pictureBox1.Visible = true;
            comboBox1.Visible = true;
            comboBox3.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e) // Female button
        {
            WebClient wb = new WebClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            string HWIDLIST = wb.DownloadString(srvl); //Replace "HWID List URL" with your own URL to a RAW text (txt) file with all your wanted HWIDs [Example: http://myurl.com/HWID.txt]
            if (HWIDLIST.Contains(textBox1.Text))
            {

            }
            else

            {
                System.Windows.Forms.Application.Exit();
            }
            pictureBox2.Image = rqMtx.Properties.Resources.char_boy;
            pictureBox3.Image = rqMtx.Properties.Resources.char_girl_en;
            pictureBox1.Image = rqMtx.Properties.Resources.g_default;
            pictureBox1.Visible = true;
            comboBox1.Visible = false;
            comboBox3.Visible = true;

        } 

        private void checkServers()
        {
            WebClient wb = new WebClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            string HWIDLIST = wb.DownloadString(srvl); //Replace "HWID List URL" with your own URL to a RAW text (txt) file with all your wanted HWIDs [Example: http://myurl.com/HWID.txt]
            if (HWIDLIST.Contains(textBox1.Text))
            {

            }
            else

            {
                System.Windows.Forms.Application.Exit();
            }
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("https://www.royalquest.ru/"))
                    {
                        label6.ForeColor = Color.Green;
                        label6.Text = ("Online");
                    }
                }
            }
            catch
            {
                label6.ForeColor = Color.Red;
                label6.Text = ("Offline");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }



        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
