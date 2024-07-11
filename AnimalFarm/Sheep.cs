using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    internal class Sheep
    {
        private string name;
        private int wool;
        private Random random;

        public Sheep(string nameParameter)
        {
            name = nameParameter;
            random = new Random();
        }

        public void Say()
        {
            Console.WriteLine("Bééé");
        }

        public int GetYield()
        {
            int yield = random.Next(0, 11);
            wool += yield;

            return yield;
        }

        public int ReturnFinalYield()
        {
            return wool;
        }
    }
}
