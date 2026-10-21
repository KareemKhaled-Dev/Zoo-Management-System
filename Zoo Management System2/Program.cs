namespace Zoo_Management_System2
{
    class Animal
    {
        public int Id;
        public string Name;
        public int Age;
        public string Species;
        public Animal(int id,string name,int age,string species)
        {
            Id=id;
            Name = name;
            Age = age;
            Species=species;
        }

    }
    class Zoo
    {
        public string Name;
        public string City;
        public List<Animal> animals=new List<Animal>();
        public Zoo(string name, string city)
        {
            Name = name;
            City = city;
        }
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
        public void RemoveAnimal(int id)
        {
          
            for(int i=0;i<animals.Count;i++)
            {
                if (animals[i].Id == id)
                {
                    animals.Remove(animals[i]);
                    
                    break;
                }
            }
           
        }
    }
    class ManagementZoo

    {
       public List<Zoo>zoo=new List<Zoo>();
        public void SearchAnimal(int id)
        {
            bool result = false;
            for(int i=0; i<zoo.Count; i++)
            {
                for(int j = 0; j < zoo[i].animals.Count; j++)
                {
                    if (zoo[i].animals[j].Id == id)
                    {
                        Console.WriteLine($" ID: {id} |Name: {zoo[i].animals[j].Name} | SpeciesAnimal: {zoo[i].animals[j].Species} | AgeAnimal: {zoo[i].animals[j].Age} | Name Zoo {zoo[i].Name} | City {zoo[i].City}");
                        result = true;
                    }
                }
                if (result == true)
                    break;
            }
            if (result == false)
            {
                Console.WriteLine($"{id} is not found");
            }
        }
        public bool AddId(int id)
        {
            bool result=false;
            for(int  i=0; i<zoo.Count;i++)
            {
                for(int j = 0; j < zoo[i].animals.Count; j++)
                {
                    if (zoo[i].animals[j].Id == id)
                    {
                        Console.WriteLine($"The Animal ID already exist in {zoo[i].Name}");
                        result=true;
                        break;
                    }
                }

            }
            return result;
        }
        public void DisPlayZoos()
        {
            bool result=false;
            for(int i = 0; i < zoo.Count; i++)
            {
                Console.WriteLine($" name {zoo[i].Name} | {zoo[i].City} ");
                result = true;
            }
            if (result == false)
            {
                Console.WriteLine("No zoo added now");
            }
        }
        public void DisplayAnimalsZoo(string NameZoo)
        {
            bool result = false;
            bool result2 =false;
            for(int i = 0; i < zoo.Count; i++)
            {
                if (zoo[i].Name==NameZoo)
                    result=true;
                {
                    Console.WriteLine($"Z00 {zoo[i].Name}");
                    for(int j=0; j < zoo[i].animals.Count; j++)
                    {
                        Console.WriteLine($" ID: {zoo[i].animals[j].Id} |Name: {zoo[i].animals[j].Name} | SpeciesAnimal: {zoo[i].animals[j].Species} | AgeAnimal: {zoo[i].animals[j].Age} | Name Zoo {zoo[i].Name} | City {zoo[i].City}");
                        result2 = true;
                    }
                }
            }
            if (result2 == false && result == true)
            {
                Console.WriteLine($"The {NameZoo} is empty ");
            }
            if (result == false)
            {
                Console.WriteLine("The zoo is not found");
            }
            
        }
        public void RemoveAnimalFromzoo(int AnimalId)
        {
            bool result =false;
            for(int i = 0;i < zoo.Count;i++)
            {
                for(int j = 0; j < zoo[i].animals.Count;j++)
                {
                    if (zoo[i].animals[j].Id == AnimalId)
                    {
                        zoo[i].RemoveAnimal(AnimalId);
                        result=true;
                    }
                }
            }
            if (result == false) Console.WriteLine("the ID of the Animal is not found");
        }
           
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagementZoo manage = new ManagementZoo();
            char choose;
            bool result = false;



            do
            {
                Console.WriteLine("==========Menue for manager Zoos==========");
                Console.WriteLine("A - create a Zoo ");
                Console.WriteLine("B - Add Animal to Zoo ");
                Console.WriteLine("C - Display All Zoos ");
                Console.WriteLine("D - Search Animal by ID ");
                Console.WriteLine("E - Display Animal in a Zoo ");
                Console.WriteLine("F - Remove Animal ");
                Console.WriteLine("Q - Quit");
                Console.Write("Enter your choose: ");
                choose = Convert.ToChar(Console.ReadLine().ToUpper());

                switch (choose)
                {
                    case 'A':
                        Console.Write("Enter name of the Zoo: ");
                        string NameZoo = Console.ReadLine();
                        Console.Write("Enter the city of Zoo: ");
                        string CityZoo = Console.ReadLine();
                        manage.zoo.Add(new Zoo(NameZoo, CityZoo));
                        Console.WriteLine($"The Zoo {NameZoo}");

                        break;
                    case 'B':
                        Console.Write("Enter Id for animal: ");
                        int IdAnimal = Convert.ToInt32(Console.ReadLine());
                        if (manage.AddId(IdAnimal) == false)
                        {
                            Console.Write("Enter name of the Animal: ");
                            string NameAnimal = Console.ReadLine();
                            Console.Write("Enter species of animal: ");
                            string spices = Console.ReadLine();
                            Console.Write("Enter age of Animal: ");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Animal animal = new Animal(IdAnimal, NameAnimal, age, spices);
                            Console.Write("Enter name do you wand add Animal there: ");
                            string name = Console.ReadLine();



                            for (int i = 0; i < manage.zoo.Count; i++)
                            {
                                if (manage.zoo[i].Name == name)
                                {
                                    manage.zoo[i].AddAnimal(animal);
                                    Console.WriteLine($"The Animal {NameAnimal} Added in {manage.zoo[i].Name}");
                                    result = true;
                                    break;
                                }

                            }
                            if (result == false) Console.WriteLine("The Zoo is not found");
                        }
                            result = false;
                        break;
                    case 'C':
                        manage.DisPlayZoos();
                        
                        break;
                    case 'D':
                        Console.Write("Enter Id search about Animal: ");
                        int IdSearch= Convert.ToInt32(Console.ReadLine());
                        manage.SearchAnimal(IdSearch);
                        break;
                    case 'E':
                        Console.Write("Enter name the zoo you want to show animals: ");
                        string Name_Zoo= Console.ReadLine();
                        manage.DisplayAnimalsZoo(Name_Zoo);

                        break;
                        case 'F':
                            Console.WriteLine("Enter Id by animal you want to remove from zoo");
                            int IdRemove= Convert.ToInt32(Console.ReadLine());
                           
                        manage.RemoveAnimalFromzoo(IdRemove);
                        break;
                    case 'Q':
                        Console.WriteLine("Nice job!");
                        
                            break;
                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
            } while (choose != 'Q');
            
        }
    }
}
