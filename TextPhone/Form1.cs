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
        //En Jagged Array som håller alla bokstäver som ska användas. 
        char[][] btnChars = new char[8][];
        
        //Nummret som används för att välja en char ur en array.
        int Number = 0;
        
        //lastBtn har startvärdet 10. knappen behövde ett speciellt värde vid första knapptryckning, sedan får den ett korrekt värde varje gång en knapp trycks ned. 
        int lastBtn = 10;

        int timesPressed = 0;

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

            //Markera knapp 0 när programmet startas
            btn0.Select();
        }

        private void num_radButton_CheckedChanged(object sender, EventArgs e)
        {
            //Aktiverar/Avaktiverar t9_checkbox och listboxen vid rätt tillfälle. 
            if (num_radButton.Checked == true)
            {
                t9_checkBox.Enabled = false;
                t9_checkBox.Checked = false;
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
            wordListBox.Items.Clear();
            timesPressed = 0;
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


            if (t9_checkBox.Checked == false)
            {
                //identifiera knappen på siffran i dess namn
                int btnNum = Convert.ToInt32(b.Name.Substring(3));

                //Ta fram rätt nummer beroende på antal klick
                Number = tid(Number, Convert.ToInt32(b.Name.Substring(3)));

                start = DateTime.Now;
                timer1.Start();

                if (txt_radButton.Checked == true)
                {
                    //Button 0 och 1 har ingen funktion när man skriver ut bokstäver
                    if (b.Name == "btn0" || b.Name == "btn1")
                    {

                    }
                    else
                    {
                        //Använd siffran i knappens namn för att ta reda på vilken array som ska användas, använd sedan antalet klick för att ta reda på vilken char ur den arrayen som ska användas. 
                        textBox1.Text += btnChars[btnNum - 2][Number].ToString();
                    }
                }
                else if (num_radButton.Checked == true)
                {
                    //Använd siffrann i knappens namn för att skriva ut en siffra
                    textBox1.Text += b.Name.Substring(3);
                }
            }
            else
            {
                timesPressed++;
                int pressedBtn = Convert.ToInt32(b.Name.Substring(3)) - 2;
                int counter = 0;
                textBox1.Text += "" + btnChars[pressedBtn][0];
                for (int i = 0; i < (btnChars[pressedBtn]).Length; i++)
                {
                    wordListBox.Items.Add(btnChars[pressedBtn][i]);
                    counter++;
                }

                permutations(pressedBtn, wordListBox.Items.Count - counter, timesPressed);
                

            }
            
        }

        //Skickar in samma char num så man kan byta mellan bokstäverna på en knapp.
        public int tid(int prevCharNum, int btnNum)
        {
            int charNum;
            
            timer1.Stop();
            if(btnNum == lastBtn||lastBtn == 10)
            {
                charNum = prevCharNum;
            }
            else
            {
                charNum = -1;
            }
            
            
            TimeSpan tid = DateTime.Now - start;

            if (start.Millisecond > 0)
            {
                TimeSpan kontroll = TimeSpan.FromSeconds(0.7);
                if (tid < kontroll)
                {
                    if (btnNum != 7&&btnNum!=9)
                    {
                        if (charNum >= 2)
                        {
                            charNum = 0;
                        }
                        else
                        {
                            charNum++;
                        }
                    }
                    else
                    {
                        if (charNum >= 3)
                        {
                            charNum = 0;
                        }
                        else
                        {
                            charNum++;
                        }
                    }
                    
                    //Tar bort det förra tecknet då man växlar mellan bokstäver med samma knapp, utesluter även kanpp 1 och 0 i och med att de tar bort tecken om man klickar på dem. 
                    if(btnNum == lastBtn&&btnNum != 1&&btnNum != 0)
                    {
                        textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                        
                    }
                    lastBtn = btnNum;
                    return charNum;
                    
                }
                else
                {
                    charNum = 0;
                    lastBtn = btnNum;
                    return charNum;
                }
            }
            else
            {
                lastBtn = btnNum;
                return charNum;
            }
            
        }

        private void wordListBox_Click(object sender, EventArgs e)
        {
            textBox1.Text = wordListBox.SelectedItem.ToString();
        }

        public void permutations(int btnNum, int lstBoxValues, int timesPressed)
        {
            for (int i = 0; i < lstBoxValues; i++)
            {
                string firstChar = wordListBox.Items[0].ToString();

                for (int j = 0; j < btnChars[btnNum].Length; j++)
                {
                    wordListBox.Items.Add(firstChar + btnChars[btnNum][j]);
                }
                wordListBox.Items.RemoveAt(0);
                //wordListBox.Items.Remove(wordListBox.Items[0]);
            }
            for (int i = 0; i < wordListBox.Items.Count; i++)
            {
                if (wordListBox.Items[i].ToString().Length < timesPressed)
                {
                    wordListBox.Items.RemoveAt(i);
                    i = -1;
                }
            }

        }
    }
}
