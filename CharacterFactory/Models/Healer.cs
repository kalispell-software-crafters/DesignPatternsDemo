﻿using System;
using Interfaces;

namespace Factory.Models
{
    public class Healer : BaseCharacter
    {
        private readonly int hitPointsToHeal = 40;
        private readonly int hitPointThreshold = 50;

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
            if (currentHitPoints <= hitPointThreshold)
            {
                var healedHitPoints = currentHitPoints + hitPointsToHeal;
                var baseHitPoints = character.GetBaseHitPoints();
                var newHitPoints = healedHitPoints > baseHitPoints ? baseHitPoints : healedHitPoints;
                character.SetHitPoints(newHitPoints);
                Console.WriteLine($"{this.GetName()} healed {character.GetName()} {hitPointsToHeal} HP! From {currentHitPoints} to {newHitPoints}!");
            }
        }
    }
}
