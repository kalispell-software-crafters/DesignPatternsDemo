using System;
using Interfaces;

namespace Factory.Models
{
    public class Healer : BaseCharacter
    {
        public Healer(int hitPoints, string name) : base(hitPoints, name)
        {
            this.characterType = CharacterType.Healer;
        }

        public override void UseSpecialPower()
        {
            Console.WriteLine("The Healer fully heals one party member.");
        }

        public override void ReactToObservation(ICharacter character) 
        {
            int currentHitPoints = character.GetHitPoints();
            if (currentHitPoints <= 50)
            {
                int healedHitPoints = currentHitPoints + 40;
                character.SetHitPoints(healedHitPoints);
                Console.WriteLine($"{this.GetName()} healed {character.GetName()} 40 HP! From {currentHitPoints} to {healedHitPoints}!");
            }
        }
    }
}
