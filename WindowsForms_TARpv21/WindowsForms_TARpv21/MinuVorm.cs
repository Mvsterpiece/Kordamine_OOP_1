using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_TARpv21
{
    public class MinuVorm : MinuOmaVorm
    {

        public MinuVorm() { }

        public MinuVorm(string Pealkiri, string Nupp, string Fail)
        {
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = Pealkiri;
            Button nupp = new Button
            {
                Text = Nupp,
                Location = new System.Drawing.Point(150, 50),
                Size = new System.Drawing.Size(100,50),
                BackColor = System.Drawing.Color.White,
            };
            nupp.Click += Nupp_Click;
            Label failisnimi = new Label
            {
                Text = Fail,
                Location = new System.Drawing.Point(150, 100),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,

            };
            this.Controls.Add(nupp);
            this.Controls.Add(failisnimi);
        }

        private void Nupp_Click(object sender, EventArgs e)
        {
            Button nupp_sender = (Button)sender;
            var vastus = MessageBox.Show("Kas tahad muusikat kuulata?", "Küsimus",MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
            {
                using (var muusika = new SoundPlayer(@"..\..\konfuz.wav"))
                {
                    muusika.Play();
                }
            }
            else
            {
                MessageBox.Show(":(");
            }
            this.Controls.Add(nupp_sender);
        }
    }
}
