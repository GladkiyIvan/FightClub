using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub.View
{
    public interface INameInput
    {
        string Nick { get;}
        event EventHandler NameSubmitClick;
    }
}
