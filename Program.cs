using System;

namespace AnimalFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My farm has 4 animals! \n");
            CreateFarmAnimals();
        }

        public static void CreateFarmAnimals()
        {
            try
            {
                Horse myHorse = new Horse("Mr.ED");
                myHorse.MakeNoise();
                //myHorse.Eat();
                myHorse.Product();
                //myHorse.Sleep();

                Cow myCow = new Cow("Daisy");
                myCow.MakeNoise();
                //myCow.Eat();
                myCow.Product();
                //myCow.Sleep();

                Pig myPig = new Pig("Porky");
                myPig.MakeNoise();
                //myPig.Eat();
                myPig.Product();
                //myPig.Sleep();

                Sheep mySheep = new Sheep("Daisy");
                mySheep.MakeNoise();
                //mySheep.Eat();
                mySheep.Product();
                //mySheep.Sleep();
            }
            catch(Exception ex)              //Handles any execption thrown
            {
                Console.WriteLine(ex.Message);
                CreateFarmAnimals();
            }
            finally
            {
                Console.WriteLine("These were my animal farms.");
            }
        }
    }


    //abstract class all animals inherit from
    public abstract class Animal
    {
        public Animal(string animalName)
        {
            this.Name = animalName;
        }
        public string Name;

        public virtual void MakeNoise()
        {
            Console.WriteLine("Hello Human!");
        }

        public virtual void Eat()
        {
            Console.WriteLine("Yumm Yumm Yumm");
        }

        public virtual void Product()
        {
            Console.WriteLine("I provide a product!");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("ZZZZZZzzzzzzZZZzzzZZZZzzzzZZZZZZzzzzz");
        }
    }


    //Horse class inherits from Animal && overrides virtual methods
    public class Horse: Animal
    {
        public Horse(string horseName) : base(horseName)
        {
            Console.WriteLine($"{horseName} the horse says:");
        }

        public override void MakeNoise()
        {
            Console.WriteLine("NEIGH!");
        }
        public override void Eat()
        {
            Console.WriteLine("The horse eats hay.");
        }

        public override void Product()
        {
            Console.WriteLine("The horse provides transportation for May. \n");
        }

        public override void Sleep()
        {
            Console.WriteLine("The horse sleeps: " +
                              "ZZZzzzzZZZZzzzZZZZZZZZZZZZZzzzzzzzZZZzzz");
        }
    }


    //Cow class inherits from Animal && overrides virtual methods
    public class Cow : Animal
    {
        public Cow(string cowName) : base(cowName)
        {
            Console.WriteLine($"{cowName} the cow says:");
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Mooooooo!");
        }
        public override void Eat()
        {
            Console.WriteLine("The cow eats grass.");
        }

        public override void Product()
        {
            Console.WriteLine("The cow provides milk for May. \n");
        }

        public override void Sleep()
        {
            Console.WriteLine("The cow sleeps stading up: " +
                              "ZZZzzzzZZZZzzzZZZZZZZZZZZZZzzzzzzzZZZzzz");
        }
    }


    //Sheep class inherits from Animal && overrides virtual methods
    public class Sheep : Animal
    {
        public Sheep(string sheepName) : base(sheepName)
        {
            Console.WriteLine($"{sheepName} the sheep says:");
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Baaaa...");
        }
        public override void Eat()
        {
            Console.WriteLine("The sheep also eats grass.");
        }

        public override void Product()
        {
            Console.WriteLine("The sheep provides wool for May. \n");
        }

        public override void Sleep()
        {
            Console.WriteLine("The sheep sleeps in a herd: " +
                              "ZZZzzzzZZZZzzzZZZZZZZZZZZZZzzzzzzzZZZzzz");
        }
    }


    //Pig class inherits from Animal && overrides virtual methods
    public class Pig : Animal
    {
        public Pig(string pigName) : base(pigName)
        {
            Console.WriteLine($"{pigName} the pig says:");
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Oink Oink!");
        }
        public override void Eat()
        {
            Console.WriteLine("The pig eats Mary's scraps.");
        }

        public override void Product()
        {
            Console.WriteLine("The pig provides bacon for May. \n");
        }

        public override void Sleep()
        {
            Console.WriteLine("The pig sleeps in the mud: " +
                              "ZZZzzzzZZZZzzzZZZZZZZZZZZZZzzzzzzzZZZzzz");
        }
    }
}
