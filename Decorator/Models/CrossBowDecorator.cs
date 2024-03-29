﻿using System;
using Interfaces;

namespace Decorator.Models
{
    public class CrossBowDecorator : BaseCharacterDecorator
    {
        public CrossBowDecorator(ICharacter character) : base(character)
        {
            this.hitPointIncrease = 30;
            this.characterType = CharacterType.CrossBow;
        }

        public override void UseSpecialPower()
        {
            Console.WriteLine("The Cross Bow Archer fires at each enemy.");
            this.character.UseSpecialPower();
        }

        public override void ReactToObservation(ICharacter character)
        {
            this.character.ReactToObservation(character);
        }
    }
}
