using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        
        [HttpGet("users")]
        public User GetUsers()
        {
            List<User> users = new List<User>();
            
            var user = new User(1, "Jolie Lennon", "joliLe", "jolie@gmail.com",new Address("Gerry Street","Apt 52","London","8597863-72", new Geo("-85.7593", "89.2789")),"123456987","jolie.org",new Company("Jolie's company", "Multi-layered client-server neural-net", "harness real-time e-markets"));
           
            var user1 = new User(2, "Angela Bruce", "angeB", "angela.bruce@gmail.com", new Address("Main Street", "38 Suite", "Gwenborough", "9298-789", new Geo("-37.87925", "-45.89235")), "87452369", "angelabruce.net", new Company("Deckow-Crist", "Proactive didactic contingency", "synergize scalable supply-chains"));
          
            var user2 = new User(3, "Clay Hans", "clay", "clay.hans@gmail.com", new Address("Hello Street", "Apt 43", "Nantes", "89823-78", new Geo("-42.5892", "-38.9882")), "102589389", "hello.net", new Company("TechPro", "Face to face bifurcated interface", "e-enable strategic applications"));
            var user3 = new User(4, "Bob Johnson", "bobJhnsn", "bob@gmail.com", new Address("King Street", "44 Suite", "Bristol", "235698-145", new Geo("-36.8962", "-48.9782")), "325698784", "manage.info", new Company("InvestTech", "Switchable contextually-based project", "aggregate real-time technologies"));
            var user4 = new User(5, "Sam Nolan", "samNolan", "sam.nolan@gmail.com", new Address("Maple Street", "Apt 29", "Brighton", "1213456-79", new Geo("-36.5292", "-42.9982")), "456982315", "sam.net", new Company("Provision", "Centralized empowering task-force", "target end-to-end models"));
            
            users.Add(user);
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);

            return users[0];
        }
        

    }
}
