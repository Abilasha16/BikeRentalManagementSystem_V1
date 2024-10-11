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

        public static int TotalBikes = 0;

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

        public virtual string DisplayElectricBikeInfo()
        {
            return $"BikeId : {BikeId}, Brand: {Brand}, Model: {Model}, RentalPrice: {RentalPrice}";
        }
    }
    public class ElectricBike : Bike
    {
        public decimal BatteryCapacity { get; set; }
        public int MotorPower { get; set; }

        public ElectricBike(string bikeId, string brand, string model, decimal rentalPrice,decimal batteryCapacity,int motorpower) : base(bikeId, brand, model, rentalPrice)
        {
            BatteryCapacity = batteryCapacity;
            MotorPower = motorpower;
        }

        public override string DisplayElectricBikeInfo()
        {
            return $"";
        }

    }
    public class PetrolBike : Bike
    {
        public decimal FuelTankCapacity { get; set; }
        public int EngineCapacity { get; set; }

        public PetrolBike(string bikeId, string brand, string model, decimal rentalPrice, decimal fuelcapacity, int enginecapacity) : base(bikeId, brand, model, rentalPrice)
        {
            FuelTankCapacity = fuelcapacity;
            EngineCapacity = enginecapacity;
        }

    }
}
