# api_postman
API project with C#
-----------------------------------------
.
[ApiController]
[Route("api/vehicles/{vehicleId}/info")]
    
[HttpGet("{info_id}")]  
.
-----------------------------------------------------------------

In Postman:
1. http://localhost:54056/api/vehicles/ -- get all vehicles
2. http://localhost:54056/api/vehicles/2 -- get vehicle with ID = 2
3. http://localhost:54056/api/vehicles/2/info -- get vehicle additional information from vehicle with ID = 2
4. http://localhost:54056/api/vehicles/2/info/3  -- additional info number 3. 

If you put another ID for vehicle or for info you will get "Not Found"
