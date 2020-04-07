using CarsListShop_Postman.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsListShop_Postman
{
    public class VehicleDataStore
    {
        public static VehicleDataStore Current { get; } = new VehicleDataStore();

        public List<CarDetails> vehicles{ get; set; }

        



        public VehicleDataStore()
        {
            vehicles = new List<CarDetails>()
            {
                new CarDetails
                    {
                        VehicleID = 1,
                        Make = "BMW",
                        ConstructionYear = 2000,
                        VehiclePrice = 2500,
                        VehicleDetailsCollection = new List<VehicleInformations>()
                        {
                            new VehicleInformations()
                            {
                                VehicleInformationID = 1,
                                DriveType = "Rear-Wheel Drive",
                                EngineDescription = "SIDI",
                                Model = "M8"
                            },
                            new VehicleInformations()
                            {
                                VehicleInformationID = 2,
                                DriveType = "All-Wheel Drive",
                                EngineDescription = "SIDI",
                                Model = "M5 - sport"
                            }
                        }
                        
                    },
                    new CarDetails
                    {
                        VehicleID = 2,
                        Make = "BMW",
                        ConstructionYear = 2010,
                        VehiclePrice = 12500,
                        VehicleDetailsCollection = new List<VehicleInformations>()
                        {
                            new VehicleInformations()
                            {
                                VehicleInformationID = 3,
                                DriveType = "Rear-Wheel Drive",
                                EngineDescription = "SIDI",
                                Model = "X3"
                            },
                            new VehicleInformations()
                            {
                                VehicleInformationID = 4,
                                DriveType = "All-Wheel Drive",
                                EngineDescription = "SIDI",
                                Model = "X5"
                            }
                        }
                    },
                    new CarDetails
                    {
                        VehicleID = 3,
                        Make = "Audi",
                        ConstructionYear = 2010,
                        VehiclePrice = 11200,
                        VehicleDetailsCollection = new List<VehicleInformations>()
                        {
                          new VehicleInformations()
                            {
                                VehicleInformationID = 5,
                                DriveType = "Front-Wheel Drive",
                                EngineDescription = "FFS",
                                Model = "80/90"
                            }
                        }
                    },
                    new CarDetails
                    {
                        VehicleID = 4,
                        Make = "Audi",
                        ConstructionYear = 2000,
                        VehiclePrice = 750,
                        VehicleDetailsCollection = new List<VehicleInformations>()
                        {
                          new VehicleInformations()
                            {
                                VehicleInformationID = 6,
                                DriveType = "4-Wheel or All-Wheel Drive",
                                EngineDescription = "FFS",
                                Model = "quattro"
                            }
                        }
                    }
            };
        }
    }
}
