using System;
using System.Threading.Tasks;
using CMusic.Models;
using CMusic.Services;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace CMusic.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private readonly IHelloService helloService;
        private readonly IMongoDatabase db;
        private readonly IMongoCollection<tblUser> tblUser;
        public SampleDataController(IHelloService helloService)
        {
            db = new MongoClient(Database.ConnnectionString).GetDatabase(Database.Name);
            tblUser = db.Table<tblUser>();

            this.helloService = helloService;
        }

        [HttpGet("[action]")]
        public tblUser WeatherForecasts()
        {
            tblUser.InsertOne(new tblUser()
            {
                name = "Trần Mạnh Cường",
                password = DateTime.Now.ToString(),
                tblRole_Name = "Admin"
            });
            //tblUser.DeleteMany(_ => true);
            return tblUser.AsQueryable().First();
        }

        [HttpGet("[action]")]
        public ContentResult AddRole(string name)
        {
            var role = db.Table<tblRole>();
            role.InsertOne(new tblRole()
            {
                Name = name,
                Order = 1
            });
            return Content("Inserted");
        }
    }
}
