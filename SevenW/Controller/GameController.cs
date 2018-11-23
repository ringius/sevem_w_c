using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using SevenW.Models;

namespace SevenW.Controller
{
    [Route("api/[Controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        [HttpGet]
        public ActionResult<int> Test()
        {
            return 1;
        }

        [HttpGet("{id}", Name = "GetCard")]
        public ActionResult<Playcard> GetCard(long id)
        {
            return new Playcard((int)id, "test", 1);
        }
    }
}
