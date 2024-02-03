using System;
using System.Collections.Generic;

namespace Lab3App
{
    public abstract class Collectable : Displayable
    {
        public string Description { get; private set; }
        public CollectionBoard Board { get; set; }

        protected Collectable(string description)
        {
            Description = description;
        }

        public virtual void AddMe(List<Collectable> collection)
        {
            collection.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            if (this is Tool tool)
            {
                tool.DoAction();
            }
        }

        public abstract void Display();
    }
}