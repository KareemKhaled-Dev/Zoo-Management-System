namespace Zoo_Management_System
{
    class Animal
    {
        public int Id;
        public string Name;
        public int Age;
        public Animal(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
    class Zoo
    {
        public string Name;
        public List<Animal> animals = new List<Animal>();
        public Zoo(string name)
        {
            Name = name;

        }
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
    }
    class ZooManager
    {
        public List<Zoo> zoos = new List<Zoo>();
        public void SearchAnimal(string AnimalName)
        {
            for (int i = 0; i < zoos.Count; i++)
            {
                for (int j = 0; j < zoos[i].animals.Count; j++)
                {
                    if (zoos[i].animals[j].Name == AnimalName)
                    {
                        Console.WriteLine($"the aimal found in {zoos[i].Name}");
                    }
                }
            }
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
            string AnimalName;
                Zoo zoo1 = new Zoo("Cairo ZOO");
                Zoo zoo2 = new Zoo("Alex ZOO");
                zoo1.AddAnimal(new Animal(1, "Lion", 5));
                zoo1.AddAnimal(new Animal(2, "Elephant", 12));
                zoo2.AddAnimal(new Animal(3, "Tiger", 4));
                zoo2.AddAnimal(new Animal(4, "Lion", 7));
            ZooManager manager= new ZooManager();
            manager.zoos.Add(zoo1);
            manager.zoos.Add(zoo2);
            Console.Write("enter name lion want to search: ");
            AnimalName=Console.ReadLine();
            manager.SearchAnimal(AnimalName);

            

            }
        }
    
}
