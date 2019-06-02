using System;
using Interfaces;

namespace Decorator
{
    public class KnightDecorator : ICharacter
    {
        private ICharacter character;
        private CharacterType characterType;

        public KnightDecorator(ICharacter character)
        {
            this.character = character;
            this.characterType = CharacterType.Knight;
        }

        public CharacterType GetCharacterType()
        {
            return characterType;
        }

        public int GetHitPoints()
        {
            return this.character.GetHitPoints() + 50;
        }

        public string GetName()
        {
            return this.character.GetName();
        }

        public void UseSpecialPower()
        {
            Console.WriteLine("The Knight uses their sheild to protect the other party members.");
        }
    }
}
