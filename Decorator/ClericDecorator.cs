using System;
using Interfaces;

namespace Decorator
{
    public class ClericDecorator : BaseCharacterDecorator 
    {
        public ClericDecorator(ICharacter character) : base(character)
        {
            this.hitPointIncrease = 25;
            this.characterType = CharacterType.Cleric;
        }

        public override void ReactToObservation(ICharacter character)
        {
            this.character.ReactToObservation(character);
        }

        public override void UseSpecialPower()
        {
            Console.WriteLine("The Cleric uses their healing magic on all of the party members.");
            this.character.UseSpecialPower();
        }
    }
}
