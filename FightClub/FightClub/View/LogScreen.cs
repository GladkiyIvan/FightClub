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
    public partial class LogScreen : Form, ILogScreen
    {
        public LogScreen()
        {
            InitializeComponent();
        }

        public void ShowHide(bool flag)
        {
            if (flag == true)
            {
                Show();
                Location = new Point(375, 400);
            }
            else
            {
                Hide();
            }
        }

        public ListBox Log { get { return log; } }

        private void LogScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
