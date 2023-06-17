﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class QuestFactory
    {

        private static readonly List<Quest> _quests = new List<Quest>();

        static QuestFactory() 
        {
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            // creates items needed to complete the quest and its rewards

            itemsToComplete.Add(new ItemQuantity(9001, 5));
            rewardItems.Add(new ItemQuantity(1002, 1));

            // creates the quest

            _quests.Add(new Quest(1,
                "Clear the Herb Garden.",
                "Defeat the snakes in the Herbalist's Garden.",
                itemsToComplete, 25, 10, rewardItems));
        }


        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }




    }
}
