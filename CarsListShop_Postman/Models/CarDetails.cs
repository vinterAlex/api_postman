using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarsListShop_Postman.Models
{
    public class CarDetails
    {
        public CarDetails() 
        {
            //empty constructor
        }

        public CarDetails(int vehicleId)
        {
            // 1 parameter constructor
            VehicleID = vehicleId;
        }


        public int VehicleID { get; set; }


        public string Make { get; set; }

        public int ConstructionYear { get; set; }   

        
        
        public int VehiclePrice { get; set; }

        public List<CarDetails> RetrieveCars()
        {
            return new List<CarDetails>();
        }

        public int NumberOfAdditionalInformations
        {
            get
            {
                return VehicleDetailsCollection.Count; //count how many additional info's have
            }
        }

        public ICollection<VehicleInformations> VehicleDetailsCollection { get; set; }
        = new List<VehicleInformations>();

    }
}
