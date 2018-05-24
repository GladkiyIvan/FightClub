using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RogueSharp.DiceNotation;

namespace FightClub
{
    public partial class Main : Form
    {
        Actor player;
        Actor computer;

        public Main(string username)
        {
            InitializeComponent();
            lblusername.Text = username;
            player = new Actor(username);
            computer = new Actor("computer");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            player.Block += CommentUserBlock;
            player.Wound += CommentUserWound;
            player.Death += DeathHandler;
            computer.Block += CommentCompBlock;
            computer.Wound += CommentCompWound;
            computer.Death += DeathHandler;

            log.Items.Add("Надери ему задницу, сынок!");

            if (Dice.Roll("1d2") == 1)
            {
                log.Items.Add("Поздравляю! Вы ходите первым!");
                EnableDisableDef(false);
            }
            else
            {
                log.Items.Add("Противник нападает первым, берегись!");
                EnableDisableAtack(false);
            }
        }

        void Round(Actor atacker, Actor defender, BodyParts userTargetOrBlock)
        {
            log.Items.Add($"Раунд № {lblcountRound.Text}.");
            log.Items.Add("----------------------");

            BodyParts compTargetOrBlock = (BodyParts)Dice.Roll("1d3");

            if (defender.Name == "computer")
            {
                defender.SetBlock(compTargetOrBlock);
                defender.GetHit(userTargetOrBlock);
                compHP.Value = defender.HP;
            }
            else
            {
                defender.SetBlock(userTargetOrBlock);
                defender.GetHit(compTargetOrBlock);
                userHP.Value = defender.HP;
            }
        }

        void CommentUserBlock(object sender, FightEventArgs e)
        {
            log.Items.Add("Хороший блок. А теперь покажи этой девчонке, какого цвета его кишки.");
            log.Items.Add(e.Message);
            log.Items.Add("");
        }
        void CommentUserWound(object sender, FightEventArgs e)
        {
            if (e.HP > 35)
            {
                log.Items.Add("Тебе подпортили личико, парень.");
            }
            else
            {
                log.Items.Add("Я не уверен, но у тебя, кажется, вытекает глаз.");
            }
            log.Items.Add(e.Message);
            log.Items.Add("");
        }
        void CommentCompBlock(object sender, FightEventArgs e)
        {
            log.Items.Add("Отлично! Ты молодчина! А теперь постарайся хотя бы по нему попасть!");
            log.Items.Add(e.Message);
            log.Items.Add("");
        }
        void CommentCompWound(object sender, FightEventArgs e)
        {
            if (e.HP > 35)
            {
                log.Items.Add("Отличный удар парень!");
                log.Items.Add("А теперь покажи ему, на сколько на полу удобно лежать!");
            }
            else
            {
                log.Items.Add("Ты почти его добил!");
                log.Items.Add("Откуси ему ухо, потому что я тебя кормить не буду!");
            }
            log.Items.Add(e.Message);
            log.Items.Add("");
        }
        //TO DO
        void DeathHandler(object sender, FightEventArgs e)
        {
            this.Hide();
            WinLose winLose = new WinLose(e.Name);
            winLose.Show();
        }

        void EnableDisableAtack(bool flag)
        {
            btnAtackHead.Enabled = flag;
            btnAtackBody.Enabled = flag;
            btnAtackLegs.Enabled = flag;
        }
        void EnableDisableDef(bool flag)
        {
            btnDefHead.Enabled = flag;
            btnDefBody.Enabled = flag;
            btnDefLegs.Enabled = flag;
        }

        private void btnAtackHead_Click(object sender, EventArgs e)
        {
            Round(player, computer, BodyParts.Head);
            lblcountRound.Text = Convert.ToString(Convert.ToInt32(lblcountRound.Text) + 1);
            EnableDisableAtack(false);
            EnableDisableDef(true);
        }

        private void btnAtackBody_Click(object sender, EventArgs e)
        {
            Round(player, computer, BodyParts.Body);
            lblcountRound.Text = Convert.ToString(Convert.ToInt32(lblcountRound.Text) + 1);
            EnableDisableAtack(false);
            EnableDisableDef(true);
        }

        private void btnAtackLegs_Click(object sender, EventArgs e)
        {
            Round(player, computer, BodyParts.Legs);
            lblcountRound.Text = Convert.ToString(Convert.ToInt32(lblcountRound.Text) + 1);
            EnableDisableAtack(false);
            EnableDisableDef(true);
        }

        private void btnDefHead_Click(object sender, EventArgs e)
        {
            Round(computer, player, BodyParts.Head);
            EnableDisableAtack(true);
            EnableDisableDef(false);
        }

        private void btnDefBody_Click(object sender, EventArgs e)
        {
            Round(computer, player, BodyParts.Body);
            EnableDisableAtack(true);
            EnableDisableDef(false);
        }

        private void btnDefLegs_Click(object sender, EventArgs e)
        {
            Round(computer, player, BodyParts.Legs);
            EnableDisableAtack(true);
            EnableDisableDef(false);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
