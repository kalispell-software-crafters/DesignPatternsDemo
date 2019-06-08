using System;
using Interfaces;

namespace Factory.Models
{
    public class Enemy : BaseCharacter
    {
        public Enemy(int hitPoints, string name) : base(hitPoints, name)
        {
            this.characterType = CharacterType.Enemy;
        }

        public override void UseSpecialPower()
        {
            Console.WriteLine("The Enemy attacks two of the party members.");
        }

        public override void ReactToObservation(ICharacter character)
        {

        }
    }
}
