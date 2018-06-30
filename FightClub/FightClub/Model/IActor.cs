using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightClub.Model;

namespace FightClub.Model
{
    public interface IActor
    {
        string Name { get; set; }
        int HP { get; set; }
        BodyParts TargetBlock { get; set; }
        void GetHit(BodyParts target);
        void SetBlock(BodyParts target);
        event FightStateHandler Block;
        event FightStateHandler Wound;
        event FightStateHandler Death;
    }
}
