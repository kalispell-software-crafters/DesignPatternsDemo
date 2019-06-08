using System;
using Interfaces;

namespace Decorator.Models
{
    public class ClericDecorator : BaseCharacterDecorator 
    {
        private readonly int hitPointsToHeal = 80;
        private readonly int hitPointThreshold = 70;

        public ClericDecorator(ICharacter character) : base(character)
        {
            this.hitPointIncrease = 25;
            this.characterType = CharacterType.Cleric;
        }

        public override void UseSpecialPower()
        {
            Console.WriteLine("The Cleric uses their healing magic on all of the party members.");
            this.character.UseSpecialPower();
        }

        public override void ReactToObservation(ICharacter character)
        {
            var currentHitPoints = character.GetHitPoints();
            if (currentHitPoints <= hitPointThreshold)
            {
                var healedHitPoints = currentHitPoints + hitPointsToHeal;
                var baseHitPoints = character.GetBaseHitPoints();
                var newHitPoints = healedHitPoints > baseHitPoints ? baseHitPoints : healedHitPoints;
                character.SetHitPoints(newHitPoints);
                Console.WriteLine($"{this.GetName()} healed {character.GetName()} {hitPointsToHeal} HP! From {currentHitPoints} to {newHitPoints}!");
            }
            this.character.ReactToObservation(character);
        }
    }
}
