using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    public class Bike
    {
        public string BikeId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal RentalPrice { get; set; }

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
    public class ElectricBike : Bike
    {
        public decimal BatteryCapacity { get; set; }
        public int MotorPower { get; set; }

        public ElectricBike(string bikeId, string brand, string model, decimal rentalPrice) : base(bikeId, brand, model, rentalPrice)
        {
        }

    }
}
