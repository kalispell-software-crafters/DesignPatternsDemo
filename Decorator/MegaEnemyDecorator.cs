using System;
using Interfaces;

namespace Decorator
{
    public class MegaEnemyDecorator : BaseCharacter
    {
        private ICharacter character;
        private readonly int hitPointIncrease = 65;

        public MegaEnemyDecorator(ICharacter character) : base(character.GetBaseHitPoints(), character.GetName())
        {
            this.character = character;
            this.characterType = CharacterType.MegaEnemy;
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
            Console.WriteLine("The Mega Enemy wounds all of the party members.");
        }
    }
}
