using System.Collections.Generic;

namespace Interfaces
{
    public abstract class BaseCharacter : ICharacter
    {
        protected CharacterType characterType;
        protected List<ICharacter> observers = new List<ICharacter>();
        private int currentHitPoints;
        private readonly int baseHitPoints;
        private readonly string name;

        public BaseCharacter(int hitPoints, string name)
        {
            this.currentHitPoints = hitPoints;
            this.baseHitPoints = hitPoints;
            this.name = name;
        }

        public virtual string GetName()
        {
            return this.name;
        }

        public virtual int GetHitPoints()
        {
            return this.currentHitPoints;
        }

        public virtual void SetHitPoints(int hitPoints)
        {
            var newHitPoints = hitPoints > this.baseHitPoints ? this.baseHitPoints : hitPoints;
            this.currentHitPoints = newHitPoints;
        }

        public virtual int GetBaseHitPoints()
        {
            return this.baseHitPoints;
        }

        public virtual void ReceiveDamage(int damageAmount)
        {
            this.currentHitPoints -= damageAmount;
            this.NotifyObservers();
        }

        public CharacterType GetCharacterType()
        {
            return this.characterType;
        }

        public abstract void UseSpecialPower();

        public virtual void AddObserver(ICharacter character)
        {
            if (!this.observers.Contains(character))
            {
                this.observers.Add(character);
            }
        }

        public virtual void RemoveObserver(ICharacter character)
        {
            this.observers.Remove(character);
        }

        public virtual void NotifyObservers()
        {
            foreach (ICharacter character in this.observers)
            {
                character.ReactToObservation(this);
            }
        }

        public abstract void ReactToObservation(ICharacter character);
    }
}
