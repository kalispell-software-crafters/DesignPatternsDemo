using System;
using Interfaces;

namespace Factory.Models
{
    public class Healer : BaseCharacter
    {
        public Healer(int hitPoints, string name) : base(hitPoints, name)
        {
            this.characterType = CharacterType.Healer;
        }

        public override void UseSpecialPower()
        {
            Console.WriteLine("The Healer fully heals one party member.");
        }
    }
}
