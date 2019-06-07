using Interfaces;

namespace Decorator
{
    public abstract class BaseCharacterDecorator : ICharacter
    {
        protected ICharacter character;
        protected CharacterType characterType;
        protected int hitPointIncrease;

        public BaseCharacterDecorator(ICharacter character)
        {
            this.character = character;
        }

        public void AddObserver(ICharacter character)
        {
            this.character.AddObserver(character);
        }

        public int GetBaseHitPoints()
        {
            return this.character.GetBaseHitPoints() + hitPointIncrease;
        }

        public CharacterType GetCharacterType()
        {
            return this.characterType;
        }

        public int GetHitPoints()
        {
            return this.character.GetHitPoints() + hitPointIncrease;
        }

        public string GetName()
        {
            return this.character.GetName();
        }

        public void NotifyObservers()
        {
            this.character.NotifyObservers();
        }

        public abstract void ReactToObservation(ICharacter character);

        public void ReceiveDamage(int damageAmount)
        {
            this.character.ReceiveDamage(damageAmount);
        }

        public void RemoveObserver(ICharacter character)
        {
            this.character.RemoveObserver(character);
        }

        public void SetHitPoints(int hitPoints)
        {
            this.character.SetHitPoints(hitPoints);
        }

        public abstract void UseSpecialPower();
    }
}
