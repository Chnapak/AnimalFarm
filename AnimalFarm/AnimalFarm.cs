using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    internal class AnimalFarm
    {
        public void Run()
        {
            Hen Kuřátko = new Hen("Pepa");
            Cow Kravička = new Cow("Bára");
            Sheep Ovečka = new Sheep("Petra");

            bool proceed = true;

            while (proceed)
            {
                Console.WriteLine("Chceš pokračovat? (y/n)");
                bool input = (Console.ReadLine() == "y");

                if (input)
                {
                    Kuřátko.Say();
                    Console.WriteLine(Kuřátko.GetYield());

                    Kravička.Say();
                    Console.WriteLine(Kravička.GetYield());

                    Ovečka.Say();
                    Console.WriteLine(Ovečka.GetYield());
                }
                else
                {
                    proceed = false;
                }
            }

            Console.WriteLine(Kuřátko.ReturnFinalYield());
            Console.WriteLine(Kravička.ReturnFinalYield()); 
            Console.WriteLine(Ovečka.ReturnFinalYield());
        }
    }
}
