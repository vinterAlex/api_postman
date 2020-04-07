using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsListShop_Postman.Models
{
    public class VehicleRepository
    {
        public IEnumerable<CarDetails> RetrieveByVehicleID(int vehicleID)
        {
            var carList = new List<CarDetails>();

            CarDetails carInfo = new CarDetails(1)
            {
                Make = "AUDI",
                ConstructionYear = 2000,
                VehiclePrice = 2500
            };
            carList.Add(carInfo);

            carInfo = new CarDetails(2)
            {
                Make = "VW",
                ConstructionYear = 2007,
                VehiclePrice = 1250
            };

            carList.Add(carInfo);

            return carList;



        }
    }
}
