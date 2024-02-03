using System;
using System.Collections.Generic;

namespace Lab3App
{
    public class Coin : Treasure
    {
        public int Value { get; private set; }

        public Coin(string name, int score, int value) : base(name, score)
        {
            Value = value;
        }

        public override void AddMe(List<Collectable> collection)
        {
            base.AddMe(collection);
            if (Board != null)
            {
                Board.TotalValue += Value;
                Console.WriteLine($"Total Value is updated to: {Board.TotalValue}");
            }
        }

        public override void Display()
        {
            Console.WriteLine($"Coin {Description} is displayed");
        }
    }
}