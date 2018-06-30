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
    public partial class WinLose : Form, IWinLose
    {
        public WinLose()
        {
            InitializeComponent();
        }

        // IWinLose
        public string Winner
        {
            get { return lblwinner.Text; }
            set { lblwinner.Text = value; }
        }
        public string Comments
        {
            get { return lblcoachcomment.Text; }
            set { lblcoachcomment.Text = value; }
        }
        public void ShowHide(bool flag)
        {
            if (flag == true)
            {
                Show();
            }
            else
            {
                Hide();
            }
        }

        // Events
        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WinLose_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
