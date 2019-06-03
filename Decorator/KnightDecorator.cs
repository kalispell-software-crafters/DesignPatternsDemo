using System;
using Interfaces;

namespace Decorator
{
    public class KnightDecorator : BaseCharacter
    {
        private ICharacter character;

        public KnightDecorator(ICharacter character) : base(character.GetBaseHitPoints(), character.GetName())
        {
            this.character = character;
            this.characterType = CharacterType.Knight;
        }

        public override int GetBaseHitPoints()
        {
            return this.character.GetBaseHitPoints() + 50;
        }

        public override void ReactToObservation(ICharacter character)
        {

        }

        public override void UseSpecialPower()
        {
            Console.WriteLine("The Knight uses their sheild to protect the other party members.");
        }
    }
}
