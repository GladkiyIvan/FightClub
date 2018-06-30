using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub.View
{
    public interface IWinLose
    {
        string Winner { get; set; }
        string Comments { get; set; }
        void ShowHide(bool flag);
    }
}
