using Factory.Models;
using Interfaces;

namespace Factory 
{
    public class CharacterFactory : ICharacterFactory
    {
        public ICharacter CreateCharacter(CharacterType characterType)
        {
            ICharacter newCharacter;

            switch(characterType)
            {
                case CharacterType.Archer:
                    newCharacter = new Archer(80, "Archer");
                    break;
                case CharacterType.Enemy:
                    newCharacter = new Enemy(150, "Enemy");
                    break;
                case CharacterType.Healer:
                    newCharacter = new Healer(75, "Healer");
                    break;
                case CharacterType.Warrior:
                    newCharacter = new Warrior(100, "Warrior");
                    break;
                default:
                    throw new System.Exception($"Unknown character type: {characterType}");
            }

            return newCharacter;
        }
    }
}
