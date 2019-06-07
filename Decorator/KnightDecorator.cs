using System;
using Interfaces;

namespace Decorator
{
    public class KnightDecorator : BaseCharacterDecorator
    {
        public KnightDecorator(ICharacter character) : base(character)
        {
            this.hitPointIncrease = 50;
            this.characterType = CharacterType.Knight;
        }

        public override void ReactToObservation(ICharacter character)
        {
            this.character.ReactToObservation(character);
        }

        public override void UseSpecialPower()
        {
            Console.WriteLine("The Knight uses their sheild to protect the other party members.");
            this.character.UseSpecialPower();
        }
    }
}
