using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();
        static QuestFactory()
        {
            // Declare the items need to complete the quest, and its reward items
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();
            
        itemsToComplete.Add(new ItemQuantity(301, 1));
        rewardItems.Add(new ItemQuantity(0, 0));

        _quest.Add(new Quest(1,
                             "MAIN QUEST: In the darkness.",
                             "Defeat the Shadowfang Wyrm to end the suffering.",
                             itemsToComplete, 1, 50,
                             rewardItems));

        itemsToComplete.Add(new ItemQuantity(303, 100));
        rewardItems.Add(new ItemQuantity(200, 2));
            
        _quest.Add(new Quest(2,
                            "QUEST: Small Thing. Help the bothered elves.",
                            "Kill nymphs to gather 100 drowsy wings.",
                             itemsToComplete, 30, 5,
                             rewardItems));

        itemsToComplete.Add(new ItemQuantity(103, 1));

        _quest.Add(new Quest(3
                             "QUEST: Bullseye.",
                             "Buy something that can help him guard the place better",
                             itemsToComplete, 50, 15,
                             rewardItems));

        itemsToComplete.Add(new ItemQuantity(302, 20));

        _quest.Add(new Quest(4,
                             "QUEST: Moonlight",
                             "Moon Petals to complete.",
                             itemsToComplete, 60, 10,
                             rewardItems));

        itemsToComplete.Add(new ItemQuantity(300, 80));

        _quest.Add(new Quest(5,
                             "QUEST: For eternity and beyond.",
                             "Eclipse Shard to shine the darkness.",
                             itemsToComplete, 100, 25
                             rewardItems));

        itemsToComplete.Add(new ItemQuantity(100, 1));
        rewardItems.Add(new ItemQuantity(101, 1));

        _quest.Add(new Quest(6,
                             "QUEST: Lost and found.",
                             "An exchange.",
                             itemsToComplete, 200, 25,
                             rewardItems));
        }
        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
