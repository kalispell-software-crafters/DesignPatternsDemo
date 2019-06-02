namespace Interfaces
{
    public interface ICharacterFactory
    {
        ICharacter CreateCharacter(CharacterType characterType);
    }
}
