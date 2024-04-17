using System;
using Engine.Models;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster nymphs =
                        new Monster("Nymphs", "Nymphs.png", 4, 4, 5, 1);

                    nymphs.CurrentWeapon = ItemFactory.CreateGameItem(1501);

                    AddLootItem(nymphs, 300, 25);
                    AddLootItem(nymphs, 303, 75);
                    return nymphs;

                case 2:
                    Monster trolls =
                        new Monster("Trolls", "Trolls.png", 5, 5, 5, 1);

                    trolls.CurrentWeapon = ItemFactory.CreateGameItem(1502);

                    AddLootItem(trolls, 302, 25);
                    return trolls;

                case 3:
                    Monster shadowfangWyrm =

                        new Monster("Shadowfang Wyrm", "shadowfangWyrm.png", 50, 25, 10, 50);

                    ShadowfangWyrm.CurrentWeapon = ItemFactory.CreateGameItem(1503);
                    AddLootItem(shadowfangWyrm, 301, 100);
                    return shadowfangWyrm;

                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
                    
            }
        }
        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.AddItemToInventory(ItemFactory.CreateGameItem(itemID));
            }
        }
    }
}
