namespace Interfaces
{
    public interface ICharacter
    {
        int GetBaseHitPoints();
        int GetHitPoints();
        void SetHitPoints(int hitPoints);
        void ReceiveDamage(int damageAmount);

        string GetName();
        CharacterType GetCharacterType(); 
        void UseSpecialPower();

        void AddObserver(ICharacter character);
        void RemoveObserver(ICharacter character);
        void NotifyObservers();
        void ReactToObservation(ICharacter character);
    }
}
