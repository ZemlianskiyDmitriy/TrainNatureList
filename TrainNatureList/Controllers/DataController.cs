using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainNatureList.Models;

namespace TrainNatureList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        ApplicationContext db;

        public DataController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            db.Stations.Add(new Station { Name = "Test" });
            db.SaveChanges();
            return Ok(0);
        }
    }
}
