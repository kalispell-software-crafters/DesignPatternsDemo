using System;
using Interfaces;

namespace Decorator
{
    public class MegaEnemyDecorator : ICharacter
    {
        private ICharacter character;
        private CharacterType characterType;

        public MegaEnemyDecorator(ICharacter character)
        {
            this.character = character;
            this.characterType = CharacterType.MegaEnemy;
        }

        public CharacterType GetCharacterType()
        {
            return characterType;
        }

        public int GetHitPoints()
        {
            return this.character.GetHitPoints() + 65;
        }

        public string GetName()
        {
            return this.character.GetName();
        }

        public void UseSpecialPower()
        {
            Console.WriteLine("The Mega Enemy wounds all of the party members.");
        }
    }
}
