using System;

namespace Lab3App
{
    public class Tool : Collectable
    {
        public Tool(string description) : base(description)
        {
        }

        public virtual void DoAction()
        {
            Console.WriteLine($"{Description} is Used");
        }

        public override void Display()
        {
            Console.WriteLine($"{Description} is displayed");
        }
    }
}