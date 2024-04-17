using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class TraderFactory
    {
        private static readonly List<Trader> _traders = new List<Trader>();
        static TraderFactory()
        {
            Trader mayor = new Trader("Mayor Isabello Hayes");
            mayor.AddItemToInventory(ItemFactory.CreateGameItem(303));
            Trader elenion = new Trader("Elenion Evergreen");
            elenion.AddItemToInventory(ItemFactory.CreateGameItem(303));
            Trader silvannus = new Trader("Silvannus");
            silvannus.AddItemToInventory(ItemFactory.CreateGameItem(303));
            Trader mystara = new Trader("Mystara");
            mystara.AddItemToInventory(ItemFactory.CreateGameItem(303));
            Trader casimir = new Trader("Casimir");
            casimir.AddItemToInventory(ItemFactory.CreateGameItem(303));
            Trader ethereal = new Trader("Ethereal Whisperer");
            ethereal.AddItemToInventory(ItemFactory.CreateGameItem(303));
            AddTraderToList(mayor);
            AddTraderToList(elenion);
            AddTraderToList(silvannus);
            AddTraderToList(mystara);
            AddTraderToList(casimir);
            AddTraderToList(ethereal);
        }
        public static Trader GetTraderByName(string name)
        {
            return _traders.FirstOrDefault(t => t.Name == name);
        }
        private static void AddTraderToList(Trader trader)
        {
            if (_traders.Any(t => t.Name == trader.Name))
            {
                throw new ArgumentException($"There is already a trader named '{trader.Name}'");
            }
            _traders.Add(trader);
        }
    }
}
