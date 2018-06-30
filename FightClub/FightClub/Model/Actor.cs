using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightClub.Model;
using RogueSharp.DiceNotation;

namespace FightClub.Model
{
    public delegate void FightStateHandler(object sender, FightEventArgs e);

    public class Actor : IActor
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public BodyParts TargetBlock { get; set; }


        public event FightStateHandler Block;
        public event FightStateHandler Wound;
        public event FightStateHandler Death;

        public Actor(string name)
        {
            Name = name;
            HP = 100;
        }

        public void GetHit(BodyParts target)
        {
            if (target == TargetBlock)
            {
                Block?.Invoke(this, new FightEventArgs($"{Name} заблокировал удар.", Name, HP));
            }
            else
            {
                HP -= Dice.Roll("3d6+5");

                if (HP <= 0)
                {
                    HP = 0;
                    Death?.Invoke(this, new FightEventArgs($"Победил {Name}", Name, HP));
                }
                else
                {
                    Wound?.Invoke(this, new FightEventArgs($"{Name} получил ранение. У него осталось всего {HP} HP.", Name, HP));
                }
            }
        }

        public void SetBlock(BodyParts target)
        {
            TargetBlock = target;
        }
    }
}
