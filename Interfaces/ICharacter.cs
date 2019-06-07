namespace Interfaces
{
    public interface ICharacter : IObserver, ISubject
    {
        int GetBaseHitPoints();
        int GetHitPoints();
        void SetHitPoints(int hitPoints);
        void ReceiveDamage(int damageAmount);

        string GetName();
        CharacterType GetCharacterType();
        void UseSpecialPower();
    }
}
