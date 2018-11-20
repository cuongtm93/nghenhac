using System.Threading.Tasks;
using CMusic.Models;
using CMusic.Services;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
namespace CMusic.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private readonly IHelloService helloService;
        private readonly IMongoDatabase db;
        public SampleDataController(IHelloService helloService)
        {
            db = new MongoClient(Database.ConnnectionString).GetDatabase(Database.Name);
            this.helloService = helloService;
        }

        [HttpGet("[action]")]
        public ContentResult WeatherForecasts()
        {
            var user = db.GetCollection<tblUser>("user");
            var c = user.Find(u => u.name == "cường").First();
            return Content(c.password);
        }

    }
}
