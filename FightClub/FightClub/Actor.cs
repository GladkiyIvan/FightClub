using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogueSharp.DiceNotation;

namespace FightClub
{
    public class Actor
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public BodyParts TargetBlock { get; set; }

        public delegate void FightStateHandler(object sender, FightEventArgs e);

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
                OnBlock(new FightEventArgs($"{Name} заблокировал удар.", Name, HP));
            }
            else
            {
                HP -= Dice.Roll("3d6+5");

                if (HP <= 0)
                {
                    HP = 0;
                    OnDeath(new FightEventArgs($"Победил {Name}", Name, HP));
                }
                else
                {
                    OnWound(new FightEventArgs($"{Name} получил ранение. У него осталось всего {HP} HP.", Name, HP));
                }
            }
        }

        public void SetBlock(BodyParts target)
        {
            TargetBlock = target;
        }

        protected void OnBlock(FightEventArgs e)
        {
            Block?.Invoke(this, e);
        }
        protected void OnWound(FightEventArgs e)
        {
            Wound?.Invoke(this, e);
        }
        protected void OnDeath(FightEventArgs e)
        {
            Death?.Invoke(this, e);
        }
    }
}
