using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    public class Bike
    {
        private string BikeId { get; set; }
        private string Brand { get; set; }
        private string Model { get; set; }
        private decimal RentalPrice { get; set; }

        public int TotalBikes = 0;

        public Bike(string bikeId, string brand, string model, decimal rentalPrice)
        {
            BikeId = bikeId;
            Brand = brand;
            Model = model;
            RentalPrice = rentalPrice;
            TotalBikes++;
        }

        public override string ToString()
        {
            return $"BikeId : {BikeId}, Brand: {Brand}, Model: {Model}, RentalPrice: {RentalPrice:C}";
        }
    }
}
