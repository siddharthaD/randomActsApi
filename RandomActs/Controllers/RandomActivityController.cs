using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace RandomActs.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RandomActivityController : ControllerBase
{
    // GET
    [HttpGet]
    public ActionResult<RandomActivity> Index()
    {
        
        var activity = new RandomActivity() { Id = 1, Title = "Go Sleep" };
        // return NotFound();
        return Ok(activity);
    }
    
    
}