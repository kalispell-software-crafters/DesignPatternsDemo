using System;
using Interfaces;

namespace Decorator
{
    public class CrossBowDecorator : ICharacter
    {
        private ICharacter character;
        private CharacterType characterType;

        public CrossBowDecorator(ICharacter character)
        {
            this.character = character;
            this.characterType = CharacterType.CrossBow;
        }

        public CharacterType GetCharacterType()
        {
            return characterType;
        }

        public int GetHitPoints()
        {
            return this.character.GetHitPoints() + 30;
        }

        public string GetName()
        {
            return this.character.GetName();
        }

        public void UseSpecialPower()
        {
            Console.WriteLine("The Cross Bow Archer fires at each enemy.");
        }
    }
}
