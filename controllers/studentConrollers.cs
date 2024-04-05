using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace level1MiniChallenge1MVC.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase{
        [HttpGet]
        public string sayHello(string name){
            return "Hello " + name;
        }
    }
}