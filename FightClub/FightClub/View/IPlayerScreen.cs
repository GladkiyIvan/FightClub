using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub.View
{
    public interface IPlayerScreen
    {
        string Username { get; set; }
        int UserHP { get; set; }
        void ShowHide(bool flag);
        void EnableDisableAtackDef(bool flag);
        event EventHandler AtackHeadClick;
        event EventHandler AtackBodyClick;
        event EventHandler AtackLegsClick;
        event EventHandler BlockHeadClick;
        event EventHandler BlockBodyClick;
        event EventHandler BlockLegsClick;
        event EventHandler SetFirstPlayer;
    }
}
