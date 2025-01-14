﻿using System;
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
            if (ValidateBikeRentalPrice(bike.RentalPrice))
            {
                bikes.Add(bike);
                Console.WriteLine("Bike added successfully.");
            }
            else
            {
                Console.WriteLine("Please Enter Positive Value in price");
            }
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
            var bike = bikes.Find(x => x.BikeId == id);
            if(bike != null)
            {
                bike.Brand = newBrand;
                bike.Model = newModel;
                bike.RentalPrice = newPrice;
                Console.WriteLine("Bike updated successfully.");
            }
            else
            {
                Console.WriteLine("No Bikes available.");
            }
        }

        //Delete Bike
        public void DeleteBike(string id)
        {
            var bike = bikes.Find(x => x.BikeId==id);
            if(bike != null)
            {
                bikes.Remove(bike);
                Console.WriteLine("Bike deleted successfully.");
            }
            else
            {
                Console.WriteLine("No Bikes available.");
            }

        }

        public bool ValidateBikeRentalPrice(decimal price)
        {
            if (price > 0)
            {
                return true;
            }
            else
            {
                return false;              
            }
        }
    }
}
