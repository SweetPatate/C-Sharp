using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Character_Selection
{
    public partial class Form2 : Form
    {
        private readonly string chemin = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
        //int NBpicture = 1;

        public Form2(Player player1)
        {
            InitializeComponent();
            NamePlayer.Text = player1.getName();
            Dexterity.Text = player1.getDext().ToString();
            Intelligence.Text = player1.getInt().ToString();
            Strength.Text = player1.getStrength().ToString();
            Vitality.Text = player1.getVita().ToString();
            pictureBoxPlayer.Load(chemin + "\\Ressource\\picture" + player1.getNBpicture() + ".png");
        }
    }
}
