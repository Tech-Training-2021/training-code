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

| **C# Object**               |   **XML Object**                 |   **JSON Object**  |
|-----------------------------|----------------------------------|--------------------|
| class Person{               |  `<person>`                        |  "person": {       |
|   int id {get; set;}=>1     |     `<id>1</id>`                   |    "id":1,         |
|   string name               |     `<name>"John"</name> `         |    "name":"John"   | 
|       {get; set}=>"John"    |  `</person> `                      |  }                 |
| }                           |  

- **Content Negotiation** - Content negotiation occurs when the client specifies an Accept header. The default format used by ASP.NET     Core is JSON.

- To create custom formatter - create a class (MyFormatter) which inhertis from TextOutputFormatter
- ```
  services.AddControllers(options=>
          options.InputFormatters.Insert(0, new MyFormatter());
          options.OutputFormatters.Insert(0, new MyFormatter());
    );
  ```
### [Swagger or Open API](https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-5.0)
- Documentation is an important practise in SOA.

### CORS
- Cross Origin Requests
- Mordern browsers only allow same origin requests for security purpose
- Same Origin 
    - http://www.abc.com/index.html
    - http://www.abc.com/aboutus.html
- Different Origins
  - https://www.abc.net
  - https://www.abc.com
  - tcp://abc.com
  - http:www.abc.com
  - https://www.abc.com:8085

#### Enable CORS
- There are three ways to enable CORS:
1. In middleware using a named policy or default policy.
2. Using endpoint routing.
3. With the [EnableCors] attribute.