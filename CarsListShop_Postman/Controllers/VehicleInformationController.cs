using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CarsListShop_Postman.Controllers
{
    /// <summary>
    /// to get all additional informations based on the vehicle make
    /// </summary>
    [ApiController]
    [Route("api/vehicles/{vehicleId}/info")]
    public class VehicleInformationController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetVehicleInformations(int vehicleId)
        {
            var cars_make = VehicleDataStore.Current.vehicles.FirstOrDefault(c => c.VehicleID == vehicleId);


            if (cars_make == null)
            {
                return NotFound();
            }

            return Ok(cars_make.VehicleDetailsCollection);
        }

        //this {info_id} will be in continuation of the above ROUTE
        [HttpGet("{info_id}")]        
        public IActionResult GetSingleInformation(int vehicleId, int info_id)
        {
            var cars_make = VehicleDataStore.Current.vehicles.FirstOrDefault(c => c.VehicleID == vehicleId);



            if (cars_make == null)
            {
                return NotFound();
            }

            var car_info = cars_make.VehicleDetailsCollection.FirstOrDefault(c => c.VehicleInformationID == info_id);


            if (car_info == null)
            {
                return NotFound();
            }
            return Ok(car_info);
        }



    }
}
