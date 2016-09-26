using System;
using System.Windows.Forms;

namespace Tidpunkt
{
    public partial class TidpunktTest : Form
    {
        Tidpunkt tid = new Tidpunkt(0, 0, 0);

        public TidpunktTest()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void sättButton_Click(object sender, EventArgs e)
        {
            int tim = int.Parse(timTextBox.Text);
            int min = int.Parse(minTextBox.Text);
            int sek = int.Parse(sekTextBox.Text);

            tid = new Tidpunkt(tim, min, sek);
            displayLabel.Text = tid.TillSträng();
            timer1.Stop();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tid.Ticka();
            displayLabel.Text = tid.TillSträng();
        }

        private void TidpunktTest_Load(object sender, EventArgs e)
        {

        }
    }
}
