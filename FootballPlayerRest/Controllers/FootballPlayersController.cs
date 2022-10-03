using Football;
using FootballPlayerRest.Managers;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FootballPlayerRest.Controllers
{
    [Route("api/FootballPlayers")]
    [ApiController]
    public class FootballPlayersController : ControllerBase
    {
        private readonly FootballPlayersManager _manager = new FootballPlayersManager();

        // GET: api/<FootballPlayersController>
        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<FootballPlayersController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public ActionResult<FootballPlayer> Get(int id)

        {
            FootballPlayer fbPlayer = _manager.GetById(id);
            if (fbPlayer == null) return NotFound("No Such FootballPlayer, id: " + id);
            return Ok(fbPlayer);
        }

        // POST api/<FootballPlayersController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPost]
        public ActionResult<FootballPlayer> Post([FromForm] FootballPlayer value)
        {
            FootballPlayer fbPlayer = _manager.Add(value);
            if (fbPlayer == null) return NotFound("No Such FootballPlayer exist");
            return Ok(fbPlayer);
        }

        // PUT api/<FootballPlayersController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("{id}")]
        public ActionResult<FootballPlayer> Put(int id, [FromForm] FootballPlayer value)
        {
            FootballPlayer fbPlayer = _manager.Update(id, value);
            if (fbPlayer == null) return NotFound("ID does not exist, id: " + id);
            return Ok(fbPlayer);
        }

        // DELETE api/<FootballPlayersController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public ActionResult<FootballPlayer> Delete(int id)
        {
            FootballPlayer fbPlayer = _manager.Delete(id);
            if (fbPlayer == null) return NotFound("ID does not exist, id: " + id);
            return Ok(fbPlayer);
        }
    }
}
