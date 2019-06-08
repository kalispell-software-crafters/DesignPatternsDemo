using System;
using Interfaces;

namespace Factory.Models
{
    public class Archer : BaseCharacter
    {
        public Archer(int hitPoints, string name) : base(hitPoints, name)
        {
            this.characterType = CharacterType.Archer;
        }

        public override void UseSpecialPower()
        {
            Console.WriteLine("The Archer steadies their aim for the perfect shot.");
        }

        public override void ReactToObservation(ICharacter character)
        {

        }
    }
}
