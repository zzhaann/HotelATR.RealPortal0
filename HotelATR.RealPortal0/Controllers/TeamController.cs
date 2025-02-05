using HotelATR.RealPortal0.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelATR.RealPortal0.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            List<TeamViewModel> teams = new List<TeamViewModel>();

            teams.Add(new TeamViewModel()

            {
                ImagePath = "img/team/1.jpg",
                FullName = "Kathy Luis",
                Position ="( Officer )",
                Description = "Lorem ipsupm dolor sit amet, conse ctetur adipisicing elit, sed do eiumthgtipsupm dolor sit amet conse",
                TeamLinks = new List<TeamLinks>()
                {
                    new TeamLinks(){ URL="https://www.facebook.com/", LinkType="zmdi-facevook"}
                }
            });

            return View(teams);
        }
    }
}
