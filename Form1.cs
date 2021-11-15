using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            int PID = meme.GetProcIdFromName("rqmain");
            if (PID > 0)
            {
                meme.OpenProcess(PID);
            }
        }

        Mem meme = new Mem();
       
        //Address List
        string ptrSuit = "rqmain.exe+0x006C2AA8,34,0,1DC,4,8a8";
        string ptrJewel = "rqmain.exe+0x006C2AA8,34,0,1DC,4,380";
        string ptrName = "rqmain.exe+0x7E9368,4,168";

        public Form1()
        {
            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)//Убрать костюм
            {
                pictureBox1.Image = rqMtx.Properties.Resources.b_default1;
                meme.WriteMemory(ptrSuit, "Int", "0");
            }
            if (comboBox1.SelectedIndex == 1)//Варвара
            {
                pictureBox1.Image = rqMtx.Properties.Resources.b_savage;
                meme.WriteMemory(ptrSuit, "Int", "1760");
            }

            if (comboBox1.SelectedIndex == 2)//Варвара
            {
                pictureBox1.Image = rqMtx.Properties.Resources.b_exso;
                meme.WriteMemory(ptrSuit, "Int", "4273");
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)//Убрать костюм
            {
                pictureBox1.Image = rqMtx.Properties.Resources.g_default;
                meme.WriteMemory(ptrSuit, "Int", "0");
            }
            if (comboBox3.SelectedIndex == 1)//Костюм кошки
            {
                pictureBox1.Image = rqMtx.Properties.Resources.g_cat;
                meme.WriteMemory(ptrSuit, "Int", "3047");
            }
            if (comboBox3.SelectedIndex == 2)//Костюм экзомеханистки
            {
                pictureBox1.Image = rqMtx.Properties.Resources.g_exso;
                meme.WriteMemory(ptrSuit, "Int", "4267");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)//Печать Морры
            {
                meme.WriteMemory(ptrJewel, "Int", "2036");
            }
            if (comboBox2.SelectedIndex == 1)//Длань Света
            {
                meme.WriteMemory(ptrJewel, "Int", "1152");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                meme.WriteMemory(ptrName, "String", "NickName");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) 
            {
                pictureBox1.Image = rqMtx.Properties.Resources.b_default1;
                pictureBox1.Visible = true;
                comboBox1.Visible = true;
                comboBox3.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                pictureBox1.Image = rqMtx.Properties.Resources.g_default;
                pictureBox1.Visible = true;
                comboBox1.Visible = false;
                comboBox3.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = rqMtx.Properties.Resources.char_boy_en;
            pictureBox3.Image = rqMtx.Properties.Resources.char_girl;
            pictureBox1.Image = rqMtx.Properties.Resources.b_default1;
            pictureBox1.Visible = true;
            comboBox1.Visible = true;
            comboBox3.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = rqMtx.Properties.Resources.char_boy;
            pictureBox3.Image = rqMtx.Properties.Resources.char_girl_en;
            pictureBox1.Image = rqMtx.Properties.Resources.g_default;
            pictureBox1.Visible = true;
            comboBox1.Visible = false;
            comboBox3.Visible = true;

        }
    }
}
