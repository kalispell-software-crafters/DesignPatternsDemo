using System.Collections.Generic;
using Interfaces;

namespace Factory.Models
{
    public abstract class BaseCharacter : ICharacter
    {
        protected CharacterType characterType;
        protected List<ICharacter> observers = new List<ICharacter>();
        private int currentHitPoints;
        private readonly int baseHitPoints;
        private readonly string name;

        protected BaseCharacter(int hitPoints, string name)
        {
            this.currentHitPoints = hitPoints;
            this.baseHitPoints = hitPoints;
            this.name = name;
        }

        public CharacterType GetCharacterType()
        {
            return this.characterType;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetBaseHitPoints()
        {
            return this.baseHitPoints;
        }

        public int GetHitPoints()
        {
            return this.currentHitPoints;
        }

        public void SetHitPoints(int hitPoints)
        {
            var newHitPoints = hitPoints > this.baseHitPoints ? this.baseHitPoints : hitPoints;
            this.currentHitPoints = newHitPoints;
        }

        public void ReceiveDamage(int damageAmount)
        {
            this.currentHitPoints -= damageAmount;
            this.NotifyObservers();
        }

        public abstract void UseSpecialPower();

        public void AddObserver(ICharacter character)
        {
            if (!this.observers.Contains(character))
            {
                this.observers.Add(character);
            }
        }

        public void RemoveObserver(ICharacter character)
        {
            this.observers.Remove(character);
        }

        public void NotifyObservers()
        {
            foreach (ICharacter character in this.observers)
            {
                character.ReactToObservation(this);
            }
        }

        public abstract void ReactToObservation(ICharacter character);
    }
}
