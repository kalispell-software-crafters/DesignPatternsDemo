using Decorator;
using Interfaces;

namespace Factory 
{
    public class CharacterUpgradeFactory : ICharacterUpgradeFactory
    {
        public ICharacter UpgradeCharacter(ICharacter character)
        {
            ICharacter upgradedCharacter;
            CharacterType characterType = character.GetCharacterType();

            switch (characterType)
            {
                case CharacterType.Archer:
                    upgradedCharacter = new CrossBowDecorator(character);
                    break;
                case CharacterType.Enemy:
                    upgradedCharacter = new MegaEnemyDecorator(character);
                    break;
                case CharacterType.Healer:
                    upgradedCharacter = new ClericDecorator(character);
                    break;
                case CharacterType.Warrior:
                    upgradedCharacter = new KnightDecorator(character);
                    break;
                default:
                    throw new System.Exception($"Unknown character type: {characterType}.");
            }

            return upgradedCharacter;
        }
    }
}
