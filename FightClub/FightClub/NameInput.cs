using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FightClub
{
    public partial class NameInput : Form
    {
        SoundPlayer music;
        public NameInput()
        {
            InitializeComponent();
            music = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "music.wav");
            music.PlayLooping();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Main ring;

            if (!string.IsNullOrEmpty(input.Text) && !string.IsNullOrWhiteSpace(input.Text))
            {
                ring = new Main(input.Text);
            }
            else
            {
                ring = new Main("Игрок");
            }

            ring.Show();
            this.Hide();
        }
    }
}
