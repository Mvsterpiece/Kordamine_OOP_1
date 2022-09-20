using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_TARpv21
{
    public partial class MinuOmaVorm : Form
    {
        TreeView puu;
        Button nupp;
        Label silt;
        CheckBox aruut1, aruut2;
        public MinuOmaVorm()
        {
            Height = 600;
            Width = 900;
            Text = "Minu oma vorm koos elementidega"; //название формы
            puu= new TreeView();
            puu.Dock = DockStyle.Left;
            puu.Location = new Point(0,0);
            TreeNode oksad= new TreeNode("Elemendid");
            oksad.Nodes.Add(new TreeNode("Nupp-Button"));
            oksad.Nodes.Add(new TreeNode("Silt-Label"));
            oksad.Nodes.Add(new TreeNode("Dialog aken - MessageBox"));
            oksad.Nodes.Add(new TreeNode("Märkeruut - Checkbox"));


            puu.AfterSelect += Puu_AfterSelect;


            puu.Nodes.Add(oksad);
            this.Controls.Add(puu);


            
            BackColor = Color.White;

        }

        private void Puu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            silt = new Label
            {
                Text = "Minu esimene vorm",
                Font = new Font("ArialBlack", 10),
                Size = new Size(200, 50),
                Location = new Point(450, 0)
            };
            if (e.Node.Text == "Nupp-Button")
            {
                nupp = new Button();
                nupp.Text = "Vajuta siia";
                nupp.Height = 30;
                nupp.Width = 100;
                nupp.Location = new Point(200, 100);
                nupp.Click += Nupp_Click;
                this.Controls.Add(nupp);
            }
            else if (e.Node.Text == "Silt-Label")
            {
                silt = new Label
                {
                    Text = "Minu esimene vorm",
                    Font= new Font("ArialBlack",10),
                    Size = new Size(200, 50),
                    Location = new Point(450, 0)
                };
                silt.MouseEnter += Silt_MouseEnter;
                silt.MouseLeave += Silt_MouseLeave;
                this.Controls.Add(silt);
            }
            else if (e.Node.Text == "Dialog aken - MessageBox")
            {
                MessageBox.Show("Aken", "kõige lihtne aken");
                var vastus = MessageBox.Show("kas paneme aken kinni?","Valik",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(vastus==DialogResult.Yes)
                {
                    this.Close();
                }
                else { }
            }
            else if (e.Node.Text == "Märkeruut - Checkbox")
            {
                aruut1 = new CheckBox
                {
                    Checked=false,
                    Text="Üks",
                    Location= new Point(silt.Left+silt.Width,0),
                    Height=25
                };
                aruut2 = new CheckBox
                {
                    Checked = false,
                    Text = "Kaks",
                    Location = new Point(silt.Left + silt.Width, aruut1.Height),
                    Height = 25
                };
                aruut2.CheckedChanged += Aruut_1_2_Changed;
                aruut1.CheckedChanged += Aruut_1_2_Changed;

                this.Controls.Add(aruut1);
                this.Controls.Add(aruut2);

            }
        }

        private void Aruut_1_2_Changed(object sender, EventArgs e)
        {
            if (aruut1.Checked == true && aruut2.Checked == true)
            {

            }
            else if (aruut1.Checked == true && aruut2.Checked == false)
            {

            }
            else if(aruut1.Checked == false && aruut2.Checked == true)
            {

            }
            else if(aruut1.Checked == false && aruut2.Checked == false)
        }


        private void Silt_MouseEnter(object sender, EventArgs e)
        {
            silt.ForeColor = Color.White;
            silt.BackColor = Color.Black;
        }

        private void Silt_MouseLeave(object sender, EventArgs e)
        {
            silt.ForeColor = Color.Black;
            silt.BackColor = Color.Transparent;
        }

        Random random = new Random();
        private void Nupp_Click(object sender, EventArgs e)
        {
            int red, green, blue;
            red = random.Next(255);
            green = random.Next(255);
            blue= random.Next(255);

            this.BackColor = Color.FromArgb(red,green,blue);
        }

    }
}
