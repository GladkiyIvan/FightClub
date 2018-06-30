using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub.View
{
    public interface IComputerScreen
    {
        int CompHP { get; set; }
        void ShowHide(bool flag);
    }
}
