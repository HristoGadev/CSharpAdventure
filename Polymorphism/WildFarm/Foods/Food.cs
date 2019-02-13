using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;

namespace WildFarm.Foods
{
    public abstract class Food : IFood
    {
        private int quantity;

        public Food(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }
    }
}
