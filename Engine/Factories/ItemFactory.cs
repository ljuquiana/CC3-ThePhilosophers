using System.Collections.Generic;
using System.Linq;
using Engine.Models;
using Engine.Actions;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static readonly List<GameItem> _standardGameItems = new List<GameItem>();
        static ItemFactory()
        {
            BuildWeapon(100, "Basic Sword", 0, 3, 5);
            BuildWeapon(101, "Astral Slicer", 0, 20, 25);
            BuildWeapon(102, "Celestial Blade", 0, 20, 25);
            BuildWeapon(103, "SwiftShot", 15, 0, 0);
            
            BuildHealingItem(200, "Heal Potion", 20, 0);

            BuildWeapon(1501, "Nymphs Claws", 2, 2, 2);
            BuildWeapon(1502, "Trolls Magic", 4, 4, 4);
            BuildWeapon(1503, "Shadowfang Wyrm", 50, 25, 50);
            
            BuildMiscellaneousItem(300, "Eclipse Shard", 1);
            BuildMiscellaneousItem(301, "Spectral Specter", 0);
            BuildMiscellaneousItem(302, "Moon Petals", 0);
            BuildMiscellaneousItem(303, "Drowsy Wings", 0);
        }
        public static GameItem CreateGameItem(int itemTypeID)
        {
            return _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID)?.Clone();
        }
        private static void BuildMiscellaneousItem(int id, string name, int price)
        {
            _standardGameItems.Add(new GameItem(GameItem.ItemCategory.Miscellaneous, id, name, price));
        }
        private static void BuildWeapon(int id, string name, int price,
                                        int minimumDamage, int maximumDamage)
        {
            GameItem weapon = new GameItem(GameItem.ItemCategory.Weapon, id, name, price);

            weapon.Action = new AttackWithWeapon(weapon, minimumDamage, maximumDamage);

            _standardGameItems.Add(weapon);
        }
        private static void BuildHealingItem(int id, string name, int price, int hitPointsToHeal)
        {
            GameItem item = new GameItem(GameItem.ItemCategory.Consumable, id, name, price);
            item.Action = new Heal(item, hitPointsToHeal);
            _standardGameItems.Add(item);
        }
        public static string ItemName(int itemTypeID)
        {
            return _standardGameItems.FirstOrDefault(i => i.ItemTypeID == itemTypeID)?.Name ?? "";
        }
    }
}
