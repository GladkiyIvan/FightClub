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
    public partial class PlayerScreen : Form, IPlayerScreen
    {
        public PlayerScreen()
        {
            InitializeComponent();
        }

        // IPlayerScreen
        public string Username
        {
            get { return lblusername.Text; }
            set { lblusername.Text = value; }
        }
        public int UserHP
        {
            get { return userHP.Value; }
            set { userHP.Value = value; }
        }
        public void ShowHide(bool flag)
        {
            if (flag == true)
            {
                Show();
                Location = new Point(50, 10);
            }
            else
            {
                Hide();
            }
        }

        public event EventHandler AtackHeadClick;
        public event EventHandler AtackBodyClick;
        public event EventHandler AtackLegsClick;
        public event EventHandler BlockHeadClick;
        public event EventHandler BlockBodyClick;
        public event EventHandler BlockLegsClick;
        public event EventHandler SetFirstPlayer;

        private void Main_Load(object sender, EventArgs e)
        {
            SetFirstPlayer?.Invoke(this, EventArgs.Empty);
        }
      
        // Events
        private void btnAtackHead_Click(object sender, EventArgs e)
        {
            AtackHeadClick?.Invoke(this, EventArgs.Empty);
            EnableDisableAtackDef(false);
        }

        private void btnAtackBody_Click(object sender, EventArgs e)
        {
            AtackBodyClick?.Invoke(this, EventArgs.Empty);
            EnableDisableAtackDef(false);
        }

        private void btnAtackLegs_Click(object sender, EventArgs e)
        {
            AtackLegsClick?.Invoke(this, EventArgs.Empty);
            EnableDisableAtackDef(false);
        }

        private void btnDefHead_Click(object sender, EventArgs e)
        {
            BlockHeadClick?.Invoke(this, EventArgs.Empty);
            EnableDisableAtackDef(true);
        }

        private void btnDefBody_Click(object sender, EventArgs e)
        {
            BlockBodyClick?.Invoke(this, EventArgs.Empty);
            EnableDisableAtackDef(true);
        }

        private void btnDefLegs_Click(object sender, EventArgs e)
        {
            BlockLegsClick?.Invoke(this, EventArgs.Empty);
            EnableDisableAtackDef(true);
        }

        public void EnableDisableAtackDef(bool flag)
        {
            btnAtackHead.Enabled = flag;
            btnAtackBody.Enabled = flag;
            btnAtackLegs.Enabled = flag;
            btnDefHead.Enabled = !flag;
            btnDefBody.Enabled = !flag;
            btnDefLegs.Enabled = !flag;
        }

        // Form's logic
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
