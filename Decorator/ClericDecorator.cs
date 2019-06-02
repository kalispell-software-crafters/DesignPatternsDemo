using System;
using Interfaces;

namespace Decorator
{
    public class ClericDecorator : ICharacter
    {
        private ICharacter character;
        private CharacterType characterType;

        public ClericDecorator(ICharacter character)
        {
            this.character = character;
            this.characterType = CharacterType.Cleric;
        }

        public CharacterType GetCharacterType()
        {
            return characterType;
        }

        public int GetHitPoints()
        {
            return this.character.GetHitPoints() + 25;
        }

        public string GetName()
        {
            return this.character.GetName();
        }

        public void UseSpecialPower()
        {
            Console.WriteLine("The Cleric uses their healing magic on all of the party members.");
        }
    }
}
