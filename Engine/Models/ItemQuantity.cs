﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Factories;

namespace Engine.Models
{
    public class ItemQuantity
    {
        public int ItemID { get; }
        public int Quantity { get; }
        public string QuantityItemDescription =>
            $"{Quantity} {ItemFactory.ItemName(ItemID)}";
        public ItemQuantity(int itemID, int quantity)
        {
            ItemID = itemID;
            Quantity = quantity;
        }
    }
}
