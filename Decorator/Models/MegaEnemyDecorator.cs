using System;
using Interfaces;

namespace Decorator.Models
{
    public class MegaEnemyDecorator : BaseCharacterDecorator
    {
        public MegaEnemyDecorator(ICharacter character) : base(character)
        {
            this.hitPointIncrease = 65;
            this.characterType = CharacterType.MegaEnemy;
        }

        public override void UseSpecialPower()
        {
            Console.WriteLine("The Mega Enemy wounds all of the party members.");
            this.character.UseSpecialPower();
        }

        public override void ReactToObservation(ICharacter character)
        {
            this.character.ReactToObservation(character);
        }
    }
}
