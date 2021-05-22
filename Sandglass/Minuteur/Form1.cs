using System;
using System.IO;
using System.Windows.Forms;

namespace Minuteur
{
    public partial class Form1 : Form
    {
        private sablier monSablier;
        private string projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        private string path;
        private int seconde_reapeat;
        private int minute_reapeat;
        private int heure_reapeat;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            path = Path.Combine(projectFolder, @"Ressources\pause.png");
            pictureBoxPause.ImageLocation = path;

            GenerateSablier();
            affichage_label();
            
            if (monSablier.SecondesTotale > 0)
            {
                timer.Start();
            }

            seconde_reapeat = Convert.ToInt32(textBoxSeconde.Text);
            minute_reapeat = Convert.ToInt32(textBoxMinute.Text);
            heure_reapeat = Convert.ToInt32(textBoxHeure.Text);
        }

        private void repeatCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (repeatCheckBox.Checked && monSablier != null)
            {
                //textBoxNullOrWhiteSpace();
                reapeat_label.Text = "Se repete tout les :\n" + heure_reapeat + " heures, " + minute_reapeat + " minutes et " + seconde_reapeat + " secondes";
            }

            if (!repeatCheckBox.Checked)
            {
                reapeat_label.Text = null;
            }
        }

        private void timer_tick(object sender, EventArgs e)
        {
            monSablier.SecondesTotale = monSablier.SecondesTotale - 1;

            if (monSablier.SecondesTotale <= 0)
            {
                timer.Stop();
                path = Path.Combine(projectFolder, @"Ressources\analog-clock.wav");
                monSablier.ClockSound(path);

                if (repeatCheckBox.Checked == true)
                {
                    GenerateSablier(seconde_reapeat, minute_reapeat, heure_reapeat);
                    timer.Start();
                }
            }

            monSablier.convertionInverse();
            affichage_label();
        }

        private void GenerateSablier()
        {
            textBoxNullOrWhiteSpace();
            monSablier = new sablier(Int32.Parse(textBoxSeconde.Text), Int32.Parse(textBoxMinute.Text), Int32.Parse(textBoxHeure.Text));
        }


        private void GenerateSablier(int seconde, int minute, int heure)
        {
            monSablier = new sablier(seconde, minute, heure);
        }

        private void affichage_label()
        {
            Heures_label.Text = monSablier.Heures.ToString();
            Minutes_label.Text = monSablier.Minutes.ToString();
            Secondes_label.Text = monSablier.Secondes.ToString();
        }

        private void textBoxNullOrWhiteSpace()
        {
            //Si les TextBox sont vides les définir à 0
            if (string.IsNullOrWhiteSpace(textBoxSeconde.Text))
            {
                textBoxSeconde.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(textBoxMinute.Text))
            {
                textBoxMinute.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(textBoxHeure.Text))
            {
                textBoxHeure.Text = "0";
            }
        }

        private void textBoxMinute_TextChanged(object sender, EventArgs e)
        {
            if (textBoxHeure.Text != "")
            {
                if (Convert.ToInt32(textBoxMinute.Text) > 60)
                {
                    textBoxMinute.Text = "59";
                }
            }
        }

        private void textBoxSeconde_TextChanged(object sender, EventArgs e)
        {
            if (textBoxHeure.Text != "")
            {
                if (Convert.ToInt32(textBoxSeconde.Text) > 60)
                {
                    textBoxSeconde.Text = "59";
                }
            }
        }

        private void verif_int(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void pictureBoxPause_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == true && monSablier != null)
            {
                timer.Stop();
                path = Path.Combine(projectFolder, @"Ressources\ctc.png");
                pictureBoxPause.ImageLocation = path;
                return;
            }
            if (timer.Enabled == false && monSablier != null)
            {
                timer.Start();
                path = Path.Combine(projectFolder, @"Ressources\pause.png");
                pictureBoxPause.ImageLocation = path;
                return;
            }
        }
    }
}