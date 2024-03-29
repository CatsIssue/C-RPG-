﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories 
{
    public static class ItemFactory
    {
        public static List<GameItem> _standardGameItems;
        
        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();

            _standardGameItems.Add(new Weapon(1001 /* id of item */, 
                "Pointy Stick" /* name of item*/, 1 /* price of item */, 1 /* minDamage of item */, 2 /* MaxDamage of item */));
            _standardGameItems.Add(new Weapon(1002, "Rusty Sword", 5, 1, 3));
            _standardGameItems.Add(new GameItem(9001, "Snake fang", 1));
            _standardGameItems.Add(new GameItem(9002, "Snakeskin", 2));
            _standardGameItems.Add(new GameItem(9003, "Rat tail", 2));
            _standardGameItems.Add(new GameItem(9004, "Rat fur ", 2));
            _standardGameItems.Add(new GameItem(9005, "Spider fang", 1));
            _standardGameItems.Add(new GameItem(9006, "Spider silk", 2));
            
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
