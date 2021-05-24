using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Character_Selection
{
    public partial class Form1 : Form
    {
        //string chemin = Application.StartupPath.Remove(Application.StartupPath.Length - 10);
        private readonly string chemin = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;

        int NBpicture = 1;
      public Form1()
        {
            InitializeComponent();
            pictureBoxPlayer.Load(chemin + "\\Ressource\\picture" + NBpicture + ".png");
        }

        private void Validate_Click(object sender, EventArgs e)
        {
            if ((trackBarDexterity.Value + trackBarIntelligence.Value + trackBarStrength.Value + trackBarVitality.Value) == 20 & !String.IsNullOrEmpty(textBoxName.Text))
            {
                string name = textBoxName.Text;
                int dexterity = trackBarDexterity.Value;
                int intelligence = trackBarIntelligence.Value;
                int strength = trackBarStrength.Value;
                int vitality = trackBarVitality.Value;
                Player player1 = new Player(name, dexterity, intelligence, strength, vitality, NBpicture);
                Form2 form2 = new Form2(player1);
                form2.Show();
            }
            else if (String.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("You need a name adventurer");
            }
            else if ((trackBarDexterity.Value + trackBarIntelligence.Value + trackBarStrength.Value + trackBarVitality.Value) > 20)
            {
                MessageBox.Show("The sum of the statistics is higher than 20");
            }
            else
            {
                MessageBox.Show("The sum of the statistics is lower than 20");
            }
        }

        private void trackBarDexterity_Scroll(object sender, EventArgs e)
        {
            labelNBdext.Text = trackBarDexterity.Value.ToString();
            PointLeft.Text = "You have "+(20-(trackBarDexterity.Value + trackBarIntelligence.Value + trackBarStrength.Value + trackBarVitality.Value)) +" point left";
        }

        private void trackBarIntelligence_Scroll(object sender, EventArgs e)
        {
            labelNBint.Text = trackBarIntelligence.Value.ToString();
            PointLeft.Text = "You have " + (20 - (trackBarDexterity.Value + trackBarIntelligence.Value + trackBarStrength.Value + trackBarVitality.Value)) + " point left";
        }

        private void trackBarStrength_Scroll(object sender, EventArgs e)
        {
            labelNBstrength.Text = trackBarStrength.Value.ToString();
            PointLeft.Text = "You have " + (20 - (trackBarDexterity.Value + trackBarIntelligence.Value + trackBarStrength.Value + trackBarVitality.Value)) + " point left";
        }

        private void trackBarVitality_Scroll(object sender, EventArgs e)
        {
            labelNBvitality.Text = trackBarVitality.Value.ToString();
            PointLeft.Text = "You have " + (20 - (trackBarDexterity.Value + trackBarIntelligence.Value + trackBarStrength.Value + trackBarVitality.Value)) + " point left";
        }

        private void previousPicture_Click(object sender, EventArgs e)
        {
            if (NBpicture > 1)
            {
                NBpicture -= 1;
                int taillechemin = Application.StartupPath.Length;
                string chemin = Application.StartupPath.Remove(taillechemin - 10);

                pictureBoxPlayer.Load(chemin + "\\Ressource\\picture" + NBpicture + ".png");
            }
        }

        private void nextPicture_Click(object sender, EventArgs e)
        {
            if (NBpicture < 4)
            {
                NBpicture += 1;
                pictureBoxPlayer.Load(chemin + "\\Ressource\\picture" + NBpicture + ".png");
            }
        }
    }
}
