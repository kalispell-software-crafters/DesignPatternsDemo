using System;
using Interfaces;

namespace Decorator
{
    public class ClericDecorator : BaseCharacter
    {
        private ICharacter character;
        private readonly int hitPointIncrease = 25;

        public ClericDecorator(ICharacter character) : base(character.GetBaseHitPoints(), character.GetName())
        {
            this.character = character;
            this.characterType = CharacterType.Cleric;
        }

        public override int GetBaseHitPoints()
        {
            return this.character.GetBaseHitPoints() + hitPointIncrease;
        }

        public override int GetHitPoints()
        {
            return this.character.GetHitPoints() + hitPointIncrease;
        }

        public override void ReactToObservation(ICharacter character)
        {
        }

        public override void UseSpecialPower()
        {
            Console.WriteLine("The Cleric uses their healing magic on all of the party members.");
            this.character.UseSpecialPower();
        }
    }
}
