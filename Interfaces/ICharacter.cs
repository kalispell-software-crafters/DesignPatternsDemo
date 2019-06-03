namespace Interfaces
{
    public interface ICharacter
    {
        int GetHitPoints();
        void SetHitPoints(int hitPoints);
        int GetBaseHitPoints();
        void ReceiveDamage(int damageAmount);
        string GetName();
        void UseSpecialPower();
        CharacterType GetCharacterType();
        void ReactToObservation(ICharacter character);
        void AddObserver(ICharacter character);
        void RemoveObserver(ICharacter character);
        void NotifyObservers();
    }
}
