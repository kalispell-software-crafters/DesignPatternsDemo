using System;
using Interfaces;

namespace Factory.Models
{
    public class Warrior : BaseCharacter
    {
        public Warrior(int hitPoints, string name) : base(hitPoints, name)
        {
            this.characterType = CharacterType.Warrior;
        }

        public override void UseSpecialPower()
        {
            Console.WriteLine("The Warrior charges the enemy.");
        }

        public override void ReactToObservation(ICharacter character)
        {

        }
    }
}
