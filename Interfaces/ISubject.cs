namespace Interfaces
{
    public interface ISubject
    {
        void AddObserver(ICharacter character);
        void RemoveObserver(ICharacter character);
        void NotifyObservers();
    }
}
