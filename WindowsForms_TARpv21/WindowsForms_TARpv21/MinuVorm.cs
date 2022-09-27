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

        public MinuVorm(string Pealkiri)
        {
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Text = Pealkiri;
            Button nupp = new Button
            {
                Text = String.Format("Vajuta"),
                Location = new System.Drawing.Point(150, 0),
                Size = new System.Drawing.Size(100,50),
                BackColor = System.Drawing.Color.White,
            };
            nupp.Click += Nupp_Click;

            Button nupp1 = new Button
            {
                Text = String.Format("Vajuta"),
                Location = new System.Drawing.Point(150, 50),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,
            };
            nupp1.Click += Nupp_Click1;
            Button nupp2 = new Button
            {
                Text = String.Format("Vajuta"),
                Location = new System.Drawing.Point(150, 100),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,
            };
            nupp2.Click += Nupp_Click2;

            Label failisnimi = new Label
            {
                Text = String.Format("Konfuz - Кайф ты поймала"),
                Location = new System.Drawing.Point(250, 10),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,

            };
            Label failisnimi1 = new Label
            {
                Text = String.Format("Ашот труба шатал"),
                Location = new System.Drawing.Point(250, 60),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,

            };
            Label failisnimi2 = new Label
            {
                Text = String.Format("Retro - Modern Talking - Chery, Chery Lady"),
                Location = new System.Drawing.Point(250, 110),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,

            };
            Label praegune = new Label
            {
                Text = String.Format("Praegu mängib."),
                Location = new System.Drawing.Point(450, 50),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,

            };
            this.Controls.Add(nupp);
            this.Controls.Add(failisnimi);
            this.Controls.Add(nupp1);
            this.Controls.Add(failisnimi1);
            this.Controls.Add(nupp2);
            this.Controls.Add(failisnimi2);
            this.Controls.Add(praegune);
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
            private void Nupp_Click1(object sender, EventArgs e)
            {
                Button nupp_sender = (Button)sender;
                var vastus = MessageBox.Show("Kas tahad muusikat kuulata?", "Küsimus", MessageBoxButtons.YesNo);
                if (vastus == DialogResult.Yes)
                {
                    using (var muusika = new SoundPlayer(@"..\..\ashot.wav"))
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
            private void Nupp_Click2(object sender, EventArgs e)
            {
                Button nupp_sender = (Button)sender;
                var vastus = MessageBox.Show("Kas tahad muusikat kuulata?", "Küsimus", MessageBoxButtons.YesNo);
                if (vastus == DialogResult.Yes)
                {
                    using (var muusika = new SoundPlayer(@"..\..\Retro-Modern-Talking-Chery_-Chery-Lady.wav"))
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
