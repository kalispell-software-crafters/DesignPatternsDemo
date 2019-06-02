using Interfaces;

namespace Factory.Models
{
    public abstract class BaseCharacter : ICharacter
    {
        int hitPoints;
        string name;
        protected CharacterType characterType;

        public BaseCharacter(int hitPoints, string name)
        {
            this.hitPoints = hitPoints;
            this.name = name;
        }

        public int GetHitPoints()
        {
            return hitPoints;
        }

        public string GetName()
        {
            return name;
        }

        public CharacterType GetCharacterType()
        {
            return this.characterType;
        }

        public abstract void UseSpecialPower();
    }
}
