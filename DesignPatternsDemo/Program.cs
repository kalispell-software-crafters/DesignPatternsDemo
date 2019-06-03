using System;
using System.Collections.Generic;
using System.Linq;
using Factory;
using Interfaces;

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ICharacterFactory characterFactory = new CharacterFactory();
            List<ICharacter> party = CreateParty(characterFactory);
            List<ICharacter> enemies = CreateEnemyParty(characterFactory);
            ListAllCharaters(party, enemies, "Initial list of characters.");

            ICharacterUpgradeFactory characterUpgradeFactory = new CharacterUpgradeFactory();
            UpgradeCharacter(enemies, CharacterType.Enemy, characterUpgradeFactory);
            UpgradeCharacter(party, CharacterType.Healer, characterUpgradeFactory);
            ListAllCharaters(party, enemies, "Upgraded list of characters.");

            ICharacter warrior = party.First(character => character.GetCharacterType() == CharacterType.Warrior);
            warrior.ReceiveDamage(90);
            ICharacter archer = party.First(character => character.GetCharacterType() == CharacterType.Archer);
            archer.ReceiveDamage(60);

            Console.WriteLine($"Warrior's HP: {warrior.GetHitPoints()}");
            Console.WriteLine($"Archer's HP: {archer.GetHitPoints()}");

            Console.WriteLine("Press enter to quit.");
            Console.ReadLine();
        }

        static List<ICharacter> CreateParty(ICharacterFactory characterFactory)
        {           
            List<ICharacter> party = new List<ICharacter>();
            ICharacter healer = characterFactory.CreateCharacter(CharacterType.Healer);
            ICharacter warrior = characterFactory.CreateCharacter(CharacterType.Warrior);
            ICharacter archer = characterFactory.CreateCharacter(CharacterType.Archer);
            archer.AddObserver(healer);
            warrior.AddObserver(healer);
            healer.AddObserver(healer);
            party.Add(archer);
            party.Add(warrior);
            party.Add(healer);

            return party;
        }

        static List<ICharacter> CreateEnemyParty(ICharacterFactory characterFactory)
        {
            List<ICharacter> party = new List<ICharacter>();
            party.Add(characterFactory.CreateCharacter(CharacterType.Enemy));
            return party;
        }

        static void ListAllCharaters(List<ICharacter> party, List<ICharacter> enemies, string message)
        {
            Console.WriteLine(message);
            ListCharacters(party);
            ListCharacters(enemies);
        }

        static void ListCharacters(List<ICharacter> characters)
        {
            foreach(ICharacter character in characters)
            {
                GetCharacterOverview(character);
            }
            Console.WriteLine();
        }

        static void GetCharacterOverview(ICharacter character)
        {
            Console.WriteLine($"Name: {character.GetName()}");
            Console.WriteLine($"HP: {character.GetHitPoints()}");
            Console.WriteLine($"Type: {character.GetCharacterType()}");
            character.UseSpecialPower();
            Console.WriteLine();
        }

        static void UpgradeCharacter(List<ICharacter> characters, CharacterType type, ICharacterUpgradeFactory upgradeFactory)
        {
            ICharacter toUpgrade = characters.First(character => character.GetCharacterType() == type);
            ICharacter upgraded = upgradeFactory.UpgradeCharacter(toUpgrade);
            characters.Remove(toUpgrade);
            characters.Add(upgraded);
        }
    }
}
