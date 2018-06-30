using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FightClub.View;

namespace FightClub
{
    public partial class ComputerScreen : Form, IComputerScreen
    {
        public ComputerScreen()
        {
            InitializeComponent();
        }

        public void ShowHide(bool flag)
        {
            if (flag == true)
            {
                Show();
                Location = new Point(650, 10);
            }
            else
            {
                Hide();
            }
        }
        public int CompHP
        {
            get { return compHP.Value; }
            set { compHP.Value = value; }
        }

        private void ComputerScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
