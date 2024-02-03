using System;

namespace Lab3App
{
    public class Diamond : Treasure
    {
        public Diamond(string number, int score) : base(number,score)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"Diamond{Description} is displayed");
        }

    }
}