using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightClub.Model;
using RogueSharp.DiceNotation;
using FightClub.View;
using System.Windows.Forms;

namespace FightClub.Presenter
{
    public class Presenter
    {
        private readonly IActor player;
        private readonly IActor computer;
        private readonly INameInput nameInput;
        private readonly ILogScreen logScreen;
        private readonly IPlayerScreen playerScreen;
        private readonly IComputerScreen computerScreen;
        private readonly IWinLose winLose;
        int roundCounter;

        public Presenter(IActor _player, IActor _computer, INameInput _nameInput, ILogScreen _logScreen, 
            IPlayerScreen _playerScreen, IComputerScreen _computerScreen, IWinLose _winLose)
        {
            player = _player;
            computer = _computer;
            nameInput = _nameInput;
            logScreen = _logScreen;
            playerScreen = _playerScreen;
            computerScreen = _computerScreen;
            winLose = _winLose;
            roundCounter = 1;

            nameInput.NameSubmitClick += NameInput_NameSubmitClick;
            playerScreen.AtackHeadClick += PlayerScreen_AtackHeadClick;
            playerScreen.AtackBodyClick += PlayerScreen_AtackBodyClick;
            playerScreen.AtackLegsClick += PlayerScreen_AtackLegsClick;
            playerScreen.BlockHeadClick += PlayerScreen_BlockHeadClick;
            playerScreen.BlockBodyClick += PlayerScreen_BlockBodyClick;
            playerScreen.BlockLegsClick += PlayerScreen_BlockLegsClick;
            playerScreen.SetFirstPlayer += PlayerScreen_SetFirstPlayer;
            player.Block += Player_Block;
            player.Wound += Player_Wound;
            computer.Block += Computer_Block;
            computer.Wound += Computer_Wound;
            player.Death += Actor_Death;
            computer.Death += Actor_Death;
        }

        private void Actor_Death(object sender, FightEventArgs e)
        {
            if (e.Name == "computer")
            {
                winLose.Winner = "Ты победил!";
                winLose.Comments = @"К вам подходит ваш тренер: ""Молодчина, парень! Кстати, как тебя зовут?""";
            }
            else
            {
                winLose.Winner = "Ты проиграл!";
                winLose.Comments = @"Ваш тренер убегает от букмерекров и кричит: ""Я не знаю, о каких деньгах вы говорите!""";
            }

            playerScreen.ShowHide(false);
            computerScreen.ShowHide(false);
            logScreen.ShowHide(false);

            winLose.ShowHide(true);
        }

        private void PlayerScreen_SetFirstPlayer(object sender, EventArgs e)
        {
            logScreen.Log.Items.Add("Надери ему задницу, сынок!");

            if (Dice.Roll("1d2") == 1)
            {
                logScreen.Log.Items.Add("Поздравляю! Вы ходите первым!");
                playerScreen.EnableDisableAtackDef(true);
            }
            else
            {
                logScreen.Log.Items.Add("Противник нападает первым, берегись!");
                playerScreen.EnableDisableAtackDef(false);
            }
        }

        private void Computer_Wound(object sender, FightEventArgs e)
        {
            if (e.HP > 35)
            {
                logScreen.Log.Items.Add("Отличный удар парень!");
                logScreen.Log.Items.Add("А теперь покажи ему, на сколько на полу удобно лежать!");
            }
            else
            {
                logScreen.Log.Items.Add("Ты почти его добил!");
                logScreen.Log.Items.Add("Откуси ему ухо, потому что я тебя кормить не буду!");
            }
            logScreen.Log.Items.Add(e.Message);
            logScreen.Log.Items.Add("");
        }

        private void Computer_Block(object sender, FightEventArgs e)
        {
            logScreen.Log.Items.Add("Отлично! Ты молодчина! А теперь постарайся хотя бы по нему попасть!");
            logScreen.Log.Items.Add(e.Message);
            logScreen.Log.Items.Add("");
        }

        private void Player_Wound(object sender, FightEventArgs e)
        {
            if (e.HP > 35)
            {
                logScreen.Log.Items.Add("Тебе подпортили личико, парень.");
            }
            else
            {
                logScreen.Log.Items.Add("Я не уверен, но у тебя, кажется, вытекает глаз.");
            }
            logScreen.Log.Items.Add(e.Message);
            logScreen.Log.Items.Add("");
        }

        private void Player_Block(object sender, FightEventArgs e)
        {
            logScreen.Log.Items.Add("Хороший блок. А теперь покажи этой девчонке, какого цвета его кишки.");
            logScreen.Log.Items.Add(e.Message);
            logScreen.Log.Items.Add("");
        }

        private void PlayerScreen_BlockLegsClick(object sender, EventArgs e)
        {
            Round(computer, player, BodyParts.Legs, ref roundCounter);
        }

        private void PlayerScreen_BlockBodyClick(object sender, EventArgs e)
        {
            Round(computer, player, BodyParts.Body, ref roundCounter);
        }

        private void PlayerScreen_BlockHeadClick(object sender, EventArgs e)
        {
            Round(computer, player, BodyParts.Head, ref roundCounter);
        }

        private void PlayerScreen_AtackLegsClick(object sender, EventArgs e)
        {
            Round(player, computer, BodyParts.Legs, ref roundCounter);
            roundCounter += 1;
        }

        private void PlayerScreen_AtackBodyClick(object sender, EventArgs e)
        {
            Round(player, computer, BodyParts.Body, ref roundCounter);
            roundCounter += 1;
        }

        private void PlayerScreen_AtackHeadClick(object sender, EventArgs e)
        {
            Round(player, computer, BodyParts.Head, ref roundCounter);
            roundCounter += 1;
        }

        private void NameInput_NameSubmitClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameInput.Nick) && !string.IsNullOrWhiteSpace(nameInput.Nick))
            {
                player.Name = nameInput.Nick;
                playerScreen.Username = nameInput.Nick;
            }
            else
            {
                playerScreen.Username = "Игрок";
            }
            playerScreen.UserHP = 100;
            computerScreen.CompHP = 100;

            playerScreen.ShowHide(true);
            computerScreen.ShowHide(true);
            logScreen.ShowHide(true);
        }

        void Round(IActor atacker, IActor defender, BodyParts userTargetOrBlock, ref int roundCounter)
        {
            logScreen.Log.Items.Add($"Раунд № {roundCounter.ToString()}.");
            logScreen.Log.Items.Add("----------------------");

            BodyParts compTargetOrBlock = (BodyParts)Dice.Roll("1d3");

            if (defender.Name == "computer")
            {
                defender.SetBlock(compTargetOrBlock);
                defender.GetHit(userTargetOrBlock);
                computerScreen.CompHP = defender.HP;
            }
            else
            {
                defender.SetBlock(userTargetOrBlock);
                defender.GetHit(compTargetOrBlock);
                playerScreen.UserHP = defender.HP;
            }
        }
    }
}
