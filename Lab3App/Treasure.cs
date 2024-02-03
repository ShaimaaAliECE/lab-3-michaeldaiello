using System;
using System.Collections.Generic;

namespace Lab3App
{
    public class Treasure : Collectable
    {
        public int Score { get; private set; }

        public Treasure(string description, int score) : base(description)
        {
            Score = score;
        }

        public override void AddMe(List<Collectable> collection)
        {
            base.AddMe(collection);
            if (Board != null)
            {
                Board.TotalScore += Score;
                Console.WriteLine($"Total Score is updated to: {Board.TotalScore}");
            }
        }

        public override void Display()
        {
            Console.WriteLine($"{Description} is displayed");
        }
    }
}
