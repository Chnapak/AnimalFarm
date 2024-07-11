using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    internal class Hen
    {
        private string name;
        private int egg;
        private Random random;

        public Hen(string nameParameter)
        {
            name = nameParameter;
            random = new Random();
        }

        public void Say()
        {
            Console.WriteLine("Kykyrykí");
        }

        public int GetYield()
        {
            int yield = random.Next(0, 11);
            egg += yield;

            return yield;
        }

        public int ReturnFinalYield()
        {
            return egg;
        }
    }
}
