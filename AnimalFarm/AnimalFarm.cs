using AnimalFarm.AnimalClasses;

namespace AnimalFarm
{
    internal class AnimalFarm
    {
        public void Run()
        {
            // Practice and use of Classes, Atributes and Properties.

            // Declaration of animals
            var animals = new Animal[3];
            animals[0] = new Hen("Petra");
            animals[1] = new Sheep("Bára");
            animals[2] = new Cow("Pavla");

            /* This program begins and runs until user refuses to continue. 
               Each iteration give a yield of each animal. */

            bool proceed = true;

            while (proceed)
            {
                // "Want to continue? (yes/no)"
                Console.WriteLine("Chceš pokračovat? (y/n)");
                
                // If user answered yes to the previous question make animal noises and get yield.
                bool input = (Console.ReadLine() == "y");
                if (input)
                {
                    
                    // Get each animal to say something and output a yield.
                    foreach (Animal animal in animals)
                    {
                        AnimalReaction(animal);
                    }

                }
                // If user answered no to the last question end the iteration.
                else
                {
                    
                    proceed = false;
                }
            }

            // Final amount of total yield for each animal.
            Console.WriteLine("-----Total yield-----");

            foreach(Animal animal in animals)
            {
                AnimalOutput(animal);
            }

        }

        public void AnimalReaction(Animal animal)
        {
            animal.Say();
            Console.WriteLine(animal.GetYield());
        }

        public void AnimalOutput(Animal animal)
        {
            Console.WriteLine(animal.ReturnFinalYield());
        }
    }
}
