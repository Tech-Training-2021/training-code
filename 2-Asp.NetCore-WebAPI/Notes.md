### Return Types of Actions
- Specific Type (SuperHero, SuperPower)
  - Use IEnumerable for Synchronous operations but not recommended with large records
  - Use IAsyncEnumerable to return records in async way
- IActionResult (supports more or less all results as it is the super parent)
  - Use whenever you want to return multiple **ActionResult**
  - Different ActionResult like **OkObjectResult(200)**, **NotFoundResult(404)**, **BadRequestResult(400)**, **ContentResult**, **JsonResult**
- ActionResult<T>
  
### Different Attributes for Controllers and Actions
In Microsoft.AspNetCore.Mvc provides following attributes:
- [Route]
- [Bind]
- [HttpGet]
- [Produces] - specifies the data that an action returns
- [Consumes] - specifies the data that an action recieves
- [ApiController]
  
Binding Source
- [FromBody]
- [FromForm]
- [FromQuery]
- [FromRoute]
- [FromHeader]
- [FromServices]

### Formatting of Responses