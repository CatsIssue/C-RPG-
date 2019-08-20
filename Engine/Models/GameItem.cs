﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem
    {
        public int ItemTypeId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        // Creating consructor 
        public GameItem(int itemTypeId, string name, int price)
        {
            ItemTypeId = itemTypeId;
            Name = name;
            Price = price;
        }
         
        // create a clone object
        public GameItem Clone()
        {
            return new GameItem(ItemTypeId, Name, Price);
        }
    }
}
