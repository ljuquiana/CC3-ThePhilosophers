using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(-2, -1, "Farmer's Field",
                "There are rows of corn growing here, with giant rats hiding between them.",
                "CornField.png");
            newWorld.LocationAt(-2, -1).AddMonster(2, 100);
            newWorld.AddLocation(-1, -1, "Farmer's House",
                "This is the house of your neighbor, Farmer Ted.",
                "Farmhouse.png");
            newWorld.LocationAt(-1, -1).TraderHere =
                TraderFactory.GetTraderByName("Farmer Ted");
            newWorld.AddLocation(0, -1, "Home",
                "This is your home",
                "Home.png");
            newWorld.AddLocation(-1, 0, "Trading Shop",
                "The shop of Susan, the trader.",
                "TraderHouse.png");
            newWorld.LocationAt(-1, 0).TraderHere =
                TraderFactory.GetTraderByName("Susan");
            newWorld.AddLocation(0, 0, "Town square",
                "You see a fountain in the center.",
                "TownSquare.png");
            newWorld.AddLocation(1, 0, "Town Gate",
                "There is a gate here, protecting the town from Monsters.",
                "TownGate.png");
            newWorld.AddLocation(2, 0, " Forest",
                "This Forest is full of Spiders.",
                "Forest.png");
            newWorld.LocationAt(2, 0).AddMonster(3, 90);

            newWorld.AddLocation(3, 0, " Deep Forest",
                "Becareful of the Green Guy",
                "DeepForest.png");
            newWorld.LocationAt(3, 0).AddMonster(4, 50);

            newWorld.AddLocation(0, 1, "Herbalist's hut",
                "You see a small hut, with plants drying from the roof.",
                "HerbalistHut.png");
            newWorld.LocationAt(0, 1).TraderHere =
               TraderFactory.GetTraderByName("Pete the Herbalist");
            newWorld.LocationAt(0, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));
            newWorld.AddLocation(0, 2, "Herbalist's garden",
                "There are many plants here, with snakes hiding behind them.",
                "HerbalistGarden.png");
            newWorld.LocationAt(0, 2).AddMonster(1, 100);
            return newWorld;
        }
    }
}
