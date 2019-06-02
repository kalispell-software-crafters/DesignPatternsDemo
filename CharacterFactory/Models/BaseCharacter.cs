using Interfaces;

namespace Factory.Models
{
    public class BaseCharacter : ICharacter
    {
        int hitPoints;
        string name;

        public BaseCharacter(int hitPoints, string name)
        {
            this.hitPoints = hitPoints;
            this.name = name;
        }

        public int getHitPoints()
        {
            return hitPoints;
        }

        public string getName()
        {
            return name;
        }
    }
}
