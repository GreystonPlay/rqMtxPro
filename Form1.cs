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
            int PID = meme.GetProcIdFromName("rqmain");// Представим что это Basic Версия
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
        string srvl = "https://greystonsoft.000webhostapp.com/index3.txt";
        Point lastPoint;

        public Form1()
        {
            InitializeComponent();
        }

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
            switch (comboBox1.SelectedIndex) // b_suit
            {
                case 0:
                    pictureBox1.Image = rqMtx.Properties.Resources.b_default;
                    meme.WriteMemory(ptrSuit, "Int", "0");
                    break;
                case 1:
                    pictureBox1.Image = rqMtx.Properties.Resources.b_varvar;
                    meme.WriteMemory(ptrSuit, "Int", "1760");
                    break;
                case 2:
                    pictureBox1.Image = rqMtx.Properties.Resources.b_exso;
                    meme.WriteMemory(ptrSuit, "Int", "4273");
                    break;
                case 3:
                    pictureBox1.Image = rqMtx.Properties.Resources.b_ganmen;
                    meme.WriteMemory(ptrSuit, "Int", "1752");
                    break;
                case 4:
                    pictureBox1.Image = rqMtx.Properties.Resources.b_pik;
                    meme.WriteMemory(ptrSuit, "Int", "5238");
                    break;
                case 5:
                    pictureBox1.Image = rqMtx.Properties.Resources.b_demon;
                    meme.WriteMemory(ptrSuit, "Int", "3491");
                    break;
                case 6:
                    pictureBox1.Image = rqMtx.Properties.Resources.b_cherv;
                    meme.WriteMemory(ptrSuit, "Int", "4563");
                    break;
                case 7:
                    pictureBox1.Image = rqMtx.Properties.Resources.b_voitel;
                    meme.WriteMemory(ptrSuit, "Int", "3930");
                    break;
                case 8:
                    pictureBox1.Image = rqMtx.Properties.Resources.b_snej;
                    meme.WriteMemory(ptrSuit, "Int", "4148");
                    break;
                case 9:
                    pictureBox1.Image = rqMtx.Properties.Resources.b_vamp;
                    meme.WriteMemory(ptrSuit, "Int", "4440");
                    break;
                case 10:
                    pictureBox1.Image = rqMtx.Properties.Resources.b_tref;
                    meme.WriteMemory(ptrSuit, "Int", "4549");
                    break;
                case 11:
                    pictureBox1.Image = rqMtx.Properties.Resources.b_vladikcherv;
                    meme.WriteMemory(ptrSuit, "Int", "4564");
                    break;
                case 12:
                    pictureBox1.Image = rqMtx.Properties.Resources.b_buben;
                    meme.WriteMemory(ptrSuit, "Int", "5240");
                    break;
                case 13:
                    pictureBox1.Image = rqMtx.Properties.Resources.b_chasov;
                    meme.WriteMemory(ptrSuit, "Int", "5437");
                    break;
                case 14:
                    pictureBox1.Image = rqMtx.Properties.Resources.b_relic;
                    meme.WriteMemory(ptrSuit, "Int", "5442");
                    break;
                case 15:
                    pictureBox1.Image = rqMtx.Properties.Resources.b_druid;
                    meme.WriteMemory(ptrSuit, "Int", "5450");
                    break;
                case 16:
                    pictureBox1.Image = rqMtx.Properties.Resources.b_alekin;
                    meme.WriteMemory(ptrSuit, "Int", "5524");
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
            switch (comboBox3.SelectedIndex)// g_suit
            {
                case 0:
                   pictureBox1.Image = rqMtx.Properties.Resources.g_default;
                    meme.WriteMemory(ptrSuit, "Int", "0"); 
                    break;
                case 1:
                    pictureBox1.Image = rqMtx.Properties.Resources.g_kosh;
                    meme.WriteMemory(ptrSuit, "Int", "3047");
                    break;
                case 2:
                    pictureBox1.Image = rqMtx.Properties.Resources.g_exso;
                    meme.WriteMemory(ptrSuit, "Int", "4267");
                    break;
                case 3:
                    pictureBox1.Image = rqMtx.Properties.Resources.g_pik;
                    meme.WriteMemory(ptrSuit, "Int", "2768");
                    break;
                case 4:
                    pictureBox1.Image = rqMtx.Properties.Resources.g_demon;
                    meme.WriteMemory(ptrSuit, "Int", "3492");
                    break;
                case 5:
                    pictureBox1.Image = rqMtx.Properties.Resources.g_krolik;
                    meme.WriteMemory(ptrSuit, "Int", "4547");
                    break;
                case 6:
                    pictureBox1.Image = rqMtx.Properties.Resources.g_driad;
                    meme.WriteMemory(ptrSuit, "Int", "3440");
                    break;
                case 7:
                    pictureBox1.Image = rqMtx.Properties.Resources.g_voitel;
                    meme.WriteMemory(ptrSuit, "Int", "3929");
                    break;
                case 8:
                    pictureBox1.Image = rqMtx.Properties.Resources.g_snej;
                    meme.WriteMemory(ptrSuit, "Int", "4147");
                    break;
                case 9:
                    pictureBox1.Image = rqMtx.Properties.Resources.g_vamp;
                    meme.WriteMemory(ptrSuit, "Int", "4441");
                    break;
                case 10:
                    pictureBox1.Image = rqMtx.Properties.Resources.g_tref;
                    meme.WriteMemory(ptrSuit, "Int", "4565");
                    break;
                case 11:
                    pictureBox1.Image = rqMtx.Properties.Resources.g_cherv;
                    meme.WriteMemory(ptrSuit, "Int", "4566");
                    break;
                case 12:
                    pictureBox1.Image = rqMtx.Properties.Resources.g_buben;
                    meme.WriteMemory(ptrSuit, "Int", "5239");
                    break;
                case 13:
                    pictureBox1.Image = rqMtx.Properties.Resources.g_chasov;
                    meme.WriteMemory(ptrSuit, "Int", "5441");
                    break;
                case 14:
                    pictureBox1.Image = rqMtx.Properties.Resources.g_relic;
                    meme.WriteMemory(ptrSuit, "Int", "5443");
                    break;
                case 15:
                    pictureBox1.Image = rqMtx.Properties.Resources.g_nimf;
                    meme.WriteMemory(ptrSuit, "Int", "5445");
                    break;
                case 16:
                    pictureBox1.Image = rqMtx.Properties.Resources.g_kolom;
                    meme.WriteMemory(ptrSuit, "Int", "5525");
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
            switch (comboBox2.SelectedIndex) // jewel
            {
                case 0:
                    meme.WriteMemory(ptrJewel, "Int", "0");
                    break;
                case 1:
                    meme.WriteMemory(ptrJewel, "Int", "228");// Фантом
                    break;
                case 2:
                    meme.WriteMemory(ptrJewel, "Int", "1152");//Длань Света
                    break;
                case 3:
                    meme.WriteMemory(ptrJewel, "Int", "2036");//Печать Морры
                    break;
                case 4:
                    meme.WriteMemory(ptrJewel, "Int", "4353");//Гуфсла
                    break;
                case 5:
                    meme.WriteMemory(ptrJewel, "Int", "1151");//Крылья ангела
                    break;
                case 6:
                    meme.WriteMemory(ptrJewel, "Int", "169");//Тяга к приключениям
                    break;
                case 7:
                    meme.WriteMemory(ptrJewel, "Int", "170");//Опытный искатель приключений
                    break;
                case 8:
                    meme.WriteMemory(ptrJewel, "Int", "227");//Глаз Носферату
                    break;
                case 9:
                    meme.WriteMemory(ptrJewel, "Int", "242");//Огненная фея
                    break;
                case 10:
                    meme.WriteMemory(ptrJewel, "Int", "2325");//Осколок Света
                    break;
                case 11:
                    meme.WriteMemory(ptrJewel, "Int", "3181");//Ледяная поступь
                    break;
                case 12:
                    meme.WriteMemory(ptrJewel, "Int", "3331");//Сила любви
                    break;
                case 13:
                    meme.WriteMemory(ptrJewel, "Int", "3928");//Огненная поступь
                    break;
                case 14:
                    meme.WriteMemory(ptrJewel, "Int", "4191");//Морозная поступь
                    break;
                case 15:
                    meme.WriteMemory(ptrJewel, "Int", "4366");//Дыхание Морры
                    break;
                case 16:
                    meme.WriteMemory(ptrJewel, "Int", "4082");//Поступь Тыквенного Безумия
                    break;
                case 17:
                    meme.WriteMemory(ptrJewel, "Int", "4592");//Синий Чешир
                    break;
                case 18:
                    meme.WriteMemory(ptrJewel, "Int", "5003");//Порхающие бабочки
                    break;
                case 19:
                    meme.WriteMemory(ptrJewel, "Int", "5056");//Легкие крылья полудня
                    break;
                case 20:
                    meme.WriteMemory(ptrJewel, "Int", "5089");//Легкие прылья зари
                    break;
                case 21:
                    meme.WriteMemory(ptrJewel, "Int", "5090");//Легкие крылья леса
                    break;
                case 22:
                    meme.WriteMemory(ptrJewel, "Int", "5091");//Легкие крылья заката
                    break;
                case 23:
                    meme.WriteMemory(ptrJewel, "Int", "5092");//Легкие крылья исцеления
                    break;
                case 24:
                    meme.WriteMemory(ptrJewel, "Int", "5093");//Темные крылья кошмара
                    break;
                case 25:
                    meme.WriteMemory(ptrJewel, "Int", "5094");//Темные крылья холода
                    break;
                case 26:
                    meme.WriteMemory(ptrJewel, "Int", "5095");//Темные крылья предательства
                    break;
                case 27:
                    meme.WriteMemory(ptrJewel, "Int", "5096");//Темные крылья коварства
                    break;
                case 28:
                    meme.WriteMemory(ptrJewel, "Int", "5097");//Темные крылья иссушения
                    break;
                case 29:
                    meme.WriteMemory(ptrJewel, "Int", "5461");//Зимняя сказка
                    break;
                case 30:
                    meme.WriteMemory(ptrJewel, "Int", "5492");//Золотая поступь
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
            pictureBox1.Image = rqMtx.Properties.Resources.b_default;
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
