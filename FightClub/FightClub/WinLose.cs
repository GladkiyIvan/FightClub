using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
    public partial class WinLose : Form
    {
        public WinLose(string loser)
        {
            InitializeComponent();

            if (loser == "computer")
            {
                lblwinner.Text = "Ты победил!";
                lblcoachcomment.Text = @"К вам подходит ваш тренер: ""Молодчина, парень! Кстати, как тебя зовут?""";
            }
            else
            {
                lblwinner.Text = "Ты проиграл!";
                lblcoachcomment.Text = @"Ваш тренер убегает от букмерекров и кричит: ""Я не знаю, о каких деньгах вы говорите!""";
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WinLose_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
