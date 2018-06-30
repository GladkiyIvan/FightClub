using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using FightClub.Model;
using FightClub.Presenter;

namespace FightClub
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SoundPlayer music = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "music.wav");
            music.PlayLooping();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // View
            NameInput nameInput = new NameInput();
            PlayerScreen playerScreen = new PlayerScreen();
            ComputerScreen computerScreen = new ComputerScreen();
            LogScreen logScreen = new LogScreen();
            WinLose winLose = new WinLose();

            // Model
            Actor computer = new Actor("computer");
            Actor player = new Actor("player");

            // Presenter
            Presenter.Presenter presenter = new Presenter.Presenter(player, computer, nameInput, logScreen, playerScreen, computerScreen, winLose);

            Application.Run(nameInput);
        }
    }
}
