using System;
using System.Linq;
using System.Threading;

namespace UppgifterEF
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMain();

        }

        private static void RunMain()
        {
            var db = new MyDbContext();
            while (true)
            {


                Console.WriteLine("Enter an option");
                Console.WriteLine("1. Add a person");
                Console.WriteLine("2. Create a car");
                Console.WriteLine("3. Print");
                var switch_on = int.Parse(Console.ReadLine());
                switch (switch_on)
                {
                    case 1:
                        AddPerson(db);
                        break;
                    case 2:
                        AddCar(db);
                        break;
                    case 3:
                        Print(db);
                        break;
                    default:
                        break;
                }

            }

        }

        static void Print(MyDbContext db)
        {
            
            foreach (var item in db.Cars)
            {
                Console.WriteLine(item.Person.Name);
            }


        }
        static void AddPerson(MyDbContext db)
        {

            db.Persons.Add(CreatePerson());
            db.SaveChanges();

        }
        static Car CreateCar()
        {
            Console.Write("Brand: ");
            string brand = Console.ReadLine();

            Console.Write("Model: ");
            string model = Console.ReadLine();

            Console.Write("Owner name: ");
            string name = Console.ReadLine();

            Console.Write("Owner birthdate (yyyy-mm-dd): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            var owner = new Person { Name = name, BirthDate = birthdate };

            return new Car { Brand = brand, Model = model, Person = owner };
            

        }
        static void AddCar(MyDbContext db)
        {
            db.Cars.Add(CreateCar());
            db.SaveChanges();
        }
        static Person CreatePerson()
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.Write("Birthdate (yyyy-mm-dd): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            return new Person { Name = name, BirthDate = birthdate };
            
        }
    }

}
