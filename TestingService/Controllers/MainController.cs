using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingService.DataBase;
using System.Web;
using TestingService.Models;

namespace TestingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        ApplicationContext db;
        public MainController(ApplicationContext context)
        {
            db = context;
        }

        // POST answers/<answerId>/attachments/
        [HttpPost]
        public JsonResult Post(Guid answerId, IEnumerable<IFormFile> files)
        {
            return new JsonResult("Work was successfully done");
        }

        // POST answers/<answerId>/events/
        [HttpPost]
        public JsonResult Post(Guid answerId, AnswerEventOfREST[] events)
        {
            return new JsonResult("Work was successfully done");
        }
    }
}
