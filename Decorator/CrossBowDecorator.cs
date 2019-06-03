using System;
using Interfaces;

namespace Decorator
{
    public class CrossBowDecorator : BaseCharacter
    {
        private ICharacter character;

        public CrossBowDecorator(ICharacter character) : base(character.GetBaseHitPoints(), character.GetName())
        {
            this.character = character;
            this.characterType = CharacterType.CrossBow;
        }

        public override int GetBaseHitPoints()
        {
            return this.character.GetBaseHitPoints() + 30;
        }

        public override void ReactToObservation(ICharacter character)
        {

        }

        public override void UseSpecialPower()
        {
            Console.WriteLine("The Cross Bow Archer fires at each enemy.");
        }

    }
}
