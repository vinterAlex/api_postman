using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CarsListShop_Postman.Controllers
{
    

    [ApiController]
    //[Route("api/[controller]")] //[controler] => "car"+Controller from below.
    [Route("api/vehicles")]
    public class CarController : ControllerBase
    {



        [HttpGet]
        public IActionResult GetCars()
        {
            return Ok(VehicleDataStore.Current.vehicles); //get all vehicles
        }

        /// <summary>
        /// To search after the make of the car
        /// </summary>
        /// <param name="marca"></param>
        /// <returns></returns>
        //[HttpGet("{marca}")]
        [HttpGet("{vehicleId}")]
        public IActionResult getMarca(int vehicleId)
        {
            //var returnMarca = VehicleDataStore.Current.vehicles.Where(m => m.Make == marca);
            var returnMarca = VehicleDataStore.Current.vehicles.FirstOrDefault(m => m.VehicleID == vehicleId);

            return Ok(returnMarca);
        }


    }
}
