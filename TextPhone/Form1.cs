using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextPhone
{
    public partial class Form1 : Form
    {
        char[][] btnChars = new char[8][];
        DateTime start;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            num_radButton.Checked = true;
            t9_checkBox.Enabled = false;
            wordListBox.Enabled = false;


            //Arrays med knapparnas tecken
            btnChars[0] = new[] { 'a', 'b', 'c' };
            btnChars[1] = new[] { 'd', 'e', 'f' };
            btnChars[2] = new[] { 'g', 'h', 'i' };
            btnChars[3] = new[] { 'j', 'k', 'l' };
            btnChars[4] = new[] { 'm', 'n', 'o' };
            btnChars[5] = new[] { 'p', 'q', 'r', 's' };
            btnChars[6] = new[] { 't', 'u', 'v' };
            btnChars[7] = new[] { 'w', 'x', 'y', 'z' };

            btn0.Select();
        }

        private void num_radButton_CheckedChanged(object sender, EventArgs e)
        {
            if (num_radButton.Checked == true)
            {
                t9_checkBox.Enabled = false;
                wordListBox.Enabled = false;
            }
            else
            {
                t9_checkBox.Enabled = true;
                wordListBox.Enabled = true;
            }
        }

        //Radera allt som står i textrutan
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        //Tar endast bort det senaste tecknet i textrutan
        private void btn_Backspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        //Händelsehanterare för knapp 0-9
        private void btn1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            int btnNum = Convert.ToInt32(b.Name.Substring(3));

            start = DateTime.Now;
            timer1.Start();

            if (txt_radButton.Checked == true)
            {
                //Testa så funktionen fungerar
                if (b.Name == "btn0" || b.Name == "btn1")
                {

                }
                else
                {
                    textBox1.Text += btnChars[btnNum - 2][0].ToString();
                }
            }
            else if (num_radButton.Checked == true)
            {
                textBox1.Text += b.Name.Substring(3);
            }
        }

        public void tid()
        {
            timer1.Stop();

            TimeSpan tid = DateTime.Now - start;

            if (start.Millisecond > 0)
            {
                TimeSpan kontroll = TimeSpan.FromSeconds(0.7);
                if (tid < kontroll)
                {
                    textBox1.Text = "test funkar";
                }
                else
                {
                    textBox1.Text = "tes funkar 2";
                }
            }
        }
    }
}
