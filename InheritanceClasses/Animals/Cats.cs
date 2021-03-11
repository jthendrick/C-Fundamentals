using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClasses
{
   public class Cats : Animals
    {
        public Cats()
        {
            Console.WriteLine("This is a cat Constructor.");
            IsMammal = true;
            DietType = DietType.Carnivore;

        }
        public bool IsEvil { get; set; }
        public int HowManyWhiskers { get; set; }
        public string Color { get; set; }
        public string HairLength { get; set; }

        public virtual void Makesound()
        {
            Console.WriteLine("Meow");
        }
        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} moves quickly!");
        }

    }           // liger inherits cats
    public class Liger : Cats
    {      //ctor tab tab
        public Liger()
        {
            Console.WriteLine("This is the Liger Constructor.");

        }
        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} stalks its prey.");
            
        }
        public override void Makesound()
        {
            Console.WriteLine("ROAR!");
        }
    }
    public class Lion : Cats
    {
        public Lion()
        {
            Console.WriteLine("this is a Lion Constructor");
        }
        public override void Makesound()
        {
            Console.WriteLine("Twinkle Toes");
        }
        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} stalks its prey, lionly.");
        }
    }
}
