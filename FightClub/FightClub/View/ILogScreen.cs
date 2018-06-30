using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub.View
{
    public interface ILogScreen
    {
        ListBox Log { get; }
        void ShowHide(bool flag);
    }
}
