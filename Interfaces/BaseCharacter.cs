using System.Collections.Generic;
using Interfaces;

namespace Interfaces
{
    public abstract class BaseCharacter : ICharacter
    {
        int currentHitPoints;
        int baseHitPoints;
        string name;
        protected CharacterType characterType;
        protected List<ICharacter> observers = new List<ICharacter>();

        public BaseCharacter(int hitPoints, string name)
        {
            this.currentHitPoints = hitPoints;
            this.baseHitPoints = hitPoints;
            this.name = name;
        }

        public virtual string GetName()
        {
            return name;
        }

        public virtual int GetHitPoints()
        {
            return currentHitPoints;
        }

        public virtual void SetHitPoints(int hitPoints)
        {
            this.currentHitPoints = hitPoints;
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
