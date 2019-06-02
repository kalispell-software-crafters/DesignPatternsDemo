using System;
using System.Collections.Generic;
using Factory;
using Interfaces;

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ICharacterFactory characterFactory = new CharacterFactory();
            List<ICharacter> party = createParty(characterFactory);
            List<ICharacter> enemies = createEnemyParty(characterFactory);

            ListCharacters(party);
            ListCharacters(enemies);

            Console.WriteLine("Press enter to quit.");
            Console.ReadLine();
        }

        static List<ICharacter> createParty(ICharacterFactory characterFactory)
        {           
            List<ICharacter> party = new List<ICharacter>();
            party.Add(characterFactory.CreateCharacter(CharacterType.Archer));
            party.Add(characterFactory.CreateCharacter(CharacterType.Warrior));
            party.Add(characterFactory.CreateCharacter(CharacterType.Healer));
            return party;
        }

        static List<ICharacter> createEnemyParty(ICharacterFactory characterFactory)
        {
            List<ICharacter> party = new List<ICharacter>();
            party.Add(characterFactory.CreateCharacter(CharacterType.Enemy));
            return party;
        }

        static void ListCharacters(List<ICharacter> characters)
        {
            foreach(ICharacter character in characters)
            {
                Console.WriteLine(character.getName());
            }
        }
    }
}
