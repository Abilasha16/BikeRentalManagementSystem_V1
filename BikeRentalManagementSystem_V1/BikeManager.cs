using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    public class BikeManager
    {
        List<Bike> bikes = new List<Bike>();

        //Create Bike
        public void CreateBike(Bike bike)
        {
            bikes.Add(bike);
            Console.WriteLine("Bike added successfully.");
        }

        //View all bikes
        public void ReadBike()
        {
            if(bikes.Count>0)
            {
               foreach(var bike in bikes)
                {
                    Console.WriteLine(bike);
                }
            }
            else
            {
                Console.WriteLine("No Bikes available.");
            }
        }

        //Edit Bike
        public void UpdateBike(string id,string newBrand,string newModel,decimal newPrice)
        {
            //var bike = bikes.Find(x => x.);
        }

        //Delete Bike
        public void DeleteBike(string id)
        {
            //var bike = bikes.Find(x => x.);

        }
    }
}
