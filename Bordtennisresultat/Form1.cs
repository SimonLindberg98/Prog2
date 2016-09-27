using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bordtennisresultat
{
    public partial class Form1 : Form
    {
        Bordtennisresultat Resultat = new Bordtennisresultat();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if(b.Name.Substring(b.Name.Length - 1) == "1")
            {
                Resultat.GePoäng1();
            }
            else
            {
                Resultat.GePoäng2();
            }

            p1Points.Text = "" + Resultat.Poäng1;
            p1Set.Text = "" + Resultat.Set1;
            p2Points.Text = "" + Resultat.Poäng2;
            p2Set.Text = "" + Resultat.Set2;

            playerWin();
        }

        void playerWin()
        {
            if(Resultat.Vinst1 == true || Resultat.Vinst2 == true)
            {
                if (Resultat.Vinst1 == true)
                {
                    MessageBox.Show("Spelare 1 Vinner!");
                }
                else
                {
                    MessageBox.Show("Spelare 2 Vinner!");
                }
            }
        }
    }
}
