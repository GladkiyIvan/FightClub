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
    public partial class NameInput : Form, INameInput
    {
        public NameInput()
        {
            InitializeComponent();
        }

        // INameInput
        public string Nick
        {
            get { return input.Text; }
        }
        public event EventHandler NameSubmitClick;

        // Events
        private void submit_Click(object sender, EventArgs e)
        {
            this.Hide();

            NameSubmitClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
