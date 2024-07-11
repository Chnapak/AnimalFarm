namespace AnimalFarm.AnimalClasses
{
    // Superclass of all animals, unlike previous version, you can make new types of Animals quickly.
    public class Animal 
    {
        private string name;            // Nickname of animal
        private string resourceName;
        private string animalNoise;     // Onomatopoeias
        private int resource;           // Total amount of yields
        private int resourceOutputMin;  // How much can one animal yield per GetYield();
        private int resourceOutputMax;
        private Random random;

        // Constructor that every animal should use.
        public Animal(string name, string resourceName, string animalNoise, int resourceOutputMin, int resourceOutputMax)
        {
            this.name = name;
            this.resourceName = resourceName;
            this.animalNoise = animalNoise;
            this.resourceOutputMin = resourceOutputMin;
            this.resourceOutputMax = resourceOutputMax;

            random = new Random();
        }

        // Making animal sound.
        public void Say()
        {
            Console.WriteLine(animalNoise);
        }
        
        // Animal produces resources.
        public string GetYield()
        {
            int yield = random.Next(resourceOutputMin, resourceOutputMax);
            resource += yield;

            return "+ " + yield + " " + resourceName; // e.g. "+ 10 wool"
        }

        public string ReturnFinalYield()
        {
            return resource + " " + resourceName;   // e.g. "35 wool"
        }
    }
}
