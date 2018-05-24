using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    public class FightEventArgs : EventArgs
    {
        public string Message { get; }
        public string Name { get; }
        public int HP { get; }

        public FightEventArgs(string message, string name, int hp)
        {
            Message = message;
            Name = name;
            HP = hp;
        }
    }
}
