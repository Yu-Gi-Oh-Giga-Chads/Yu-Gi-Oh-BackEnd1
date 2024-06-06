using BusinessLayer;
using DataLayer;
using Microsoft.AspNetCore.Mvc;

namespace Yu_Gi_Oh_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostDecksController : Controller
    {
        YuGiOhDbContext _yuGiOhDbContext = new YuGiOhDbContext();

        [HttpPost("api/addnewdeck")]
        public IActionResult postNewDeck([FromBody] Deck newDeck, [FromBody] User user)
        {
            User currUser = _yuGiOhDbContext.Users.SingleOrDefault(u=>u.Id == user.Id);
            if (currUser is null)
            {
                throw new Exception("NoSuchUserException");
            }
            currUser.Decks.Add(newDeck);
            _yuGiOhDbContext.SaveChangesAsync();
            _yuGiOhDbContext.Decks.Add(newDeck);
            _yuGiOhDbContext.SaveChangesAsync();
            return CreatedAtAction("Added new deck", new Deck { Id = newDeck.Id });
        }
    }
}
