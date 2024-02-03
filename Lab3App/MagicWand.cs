using System;

namespace Lab3App
{
    public class MagicWand : Tool
    {
        public MagicWand(string name) : base(name)
        {
        }

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is used");
        }

        public override void Display()
        {
            Console.WriteLine($"MagicWand {Description} is displayed");
        }
    }
}
