using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BikeManager manager = new BikeManager();

            int option = 0;

            do
            {
                Console.WriteLine("\nBike Rental Management System:");
                Console.WriteLine("1. Add a Bike");
                Console.WriteLine("2. View All Bikes");
                Console.WriteLine("3. Update a Bike");
                Console.WriteLine("4. Delete a Bike");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option:");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Enter Bike Id:");
                        string id = Console.ReadLine();
                        Console.Write("Enter Bike Brand: ");
                        string brand = Console.ReadLine();
                        Console.Write("Enter Bike model:");
                        string model = Console.ReadLine();
                        Console.Write("Enter Bike rental price:");
                        decimal price = decimal.Parse(Console.ReadLine());
                        manager.CreateBike(new Bike(id, brand, model, price));

                        break;
                    case 2:
                        manager.ReadBike();
                        //Console.WriteLine($"ID:");
                        break;

                }




            } while (option != 5);
        }
    }
}
