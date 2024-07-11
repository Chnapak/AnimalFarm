using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    internal class Cow
    {
        private string name;
        private int milk;
        private Random random;

        public Cow(string nameParameter)
        {
            name = nameParameter;
            random = new Random();
        }

        public void Say()
        {
            Console.WriteLine("Můů");
        }

        public int GetYield()
        {
            int yield = random.Next(15, 25);
            milk += yield;

            return yield;
        }

        public int ReturnFinalYield()
        {
            return milk;
        }
    }
}
