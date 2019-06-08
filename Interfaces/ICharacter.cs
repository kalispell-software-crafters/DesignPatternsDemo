namespace Interfaces
{
    public interface ICharacter : IObserver, ISubject
    {
        CharacterType GetCharacterType(); 
        string GetName();

        int GetBaseHitPoints();
        int GetHitPoints();
        void SetHitPoints(int hitPoints);
        void ReceiveDamage(int damageAmount);

        void UseSpecialPower();
    }
}
