﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factiries 
{
    public static class ItemFactory
    {
        public static List<GameItem> _standardGameItems;
        
        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();

            _standardGameItems.Add(new Weapon(1001, "Pointy Stick", 1, 1, 2));
            _standardGameItems.Add(new Weapon(1002, "Rusty Sword", 5, 1, 3));
        }

        public static GameItem CreateGameItem(int itemTypeId)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeId == itemTypeId);

            if(standardItem != null)
            {
                return standardItem.Clone();
            }

            return null;
        }
    }
}