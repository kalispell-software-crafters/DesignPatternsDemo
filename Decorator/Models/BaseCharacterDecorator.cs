using Interfaces;

namespace Decorator.Models
{
    public abstract class BaseCharacterDecorator : ICharacter
    {
        protected ICharacter character;
        protected CharacterType characterType;
        protected int hitPointIncrease;

        protected BaseCharacterDecorator(ICharacter character)
        {
            this.character = character;
        }

        public CharacterType GetCharacterType()
        {
            return this.characterType;
        }

        public string GetName()
        {
            return this.character.GetName();
        }

        public int GetBaseHitPoints()
        {
            return this.character.GetBaseHitPoints() + hitPointIncrease;
        }

        public int GetHitPoints()
        {
            return this.character.GetHitPoints() + hitPointIncrease;
        }

        public void SetHitPoints(int hitPoints)
        {
            this.character.SetHitPoints(hitPoints);
        }

        public void ReceiveDamage(int damageAmount)
        {
            this.character.ReceiveDamage(damageAmount);
        }

        public abstract void UseSpecialPower();

        public void AddObserver(ICharacter character)
        {
            this.character.AddObserver(character);
        }

        public void RemoveObserver(ICharacter character)
        {
            this.character.RemoveObserver(character);
        }

        public void NotifyObservers()
        {
            this.character.NotifyObservers();
        }

        public abstract void ReactToObservation(ICharacter character);
    }
}
