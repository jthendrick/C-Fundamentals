using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InheritanceClasses
{
    //=1 makes the index starting at 1 rather than 0
    public enum DietType { Herbivore = 1, Omnivore, Carnivore }

    public class Animals
    {
        public Animals()
        {
            Console.WriteLine("This is an Animal Consructor.");
        }
        public String AnimalName { get; set; }

        public int NumberOfLegs { get; set; }

        public bool IsMammal { get; set; }

        public bool HasFur { get; set; }

        public DietType DietType { get; set; }

        public virtual void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }
    }
}
