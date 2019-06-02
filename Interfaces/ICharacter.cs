namespace Interfaces
{
    public interface ICharacter
    {
        int GetHitPoints();
        string GetName();
        void UseSpecialPower();
        CharacterType GetCharacterType();
    }
}
