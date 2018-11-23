using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using SevenWonder.Models;

namespace SevenWonder.Controller
{
    // [Route("api/[Controller]")]
    // [ApiController]
    public class GameController : ControllerBase
    {
        //[HttpGet]
        public ActionResult<int> Test()
        {
            return 1;
        }

        //[HttpGet("{id}", Name = "GetCard")]
        public ActionResult<Playcard> GetCard(int id)
        {
            return new Playcard(id, "test", 1, Playcard.CardType.ScienceStructure);
        }

        [HttpPost]
        public ActionResult<Playcard> PostCard([FromBody]Playcard card)
        {
            card.Type = Playcard.CardType.ScienceStructure;
            return card;            
        }


    }
}
