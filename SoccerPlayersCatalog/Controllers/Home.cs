using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoccerPlayersCatalog.Models;

namespace SoccerPlayersCatalog.Controllers
{
    public class Home : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        
        public Home(ApplicationDbContext dbContext)
        {
            _dbContext = _dbContext;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Countries = _dbContext.Countries;
            ViewBag.Genders = _dbContext.Genders;
            ViewBag.Teams = _dbContext.Teams;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(
            string name,
            string surname,
            string genderId,
            DateTime birthDate,
            string team,
            string countryId
        )
        {
            await _dbContext.Players.AddAsync(
                new Player
                {
                    Name = name, Surname = surname,
                    GenderId = int.Parse(genderId),
                    BirthDate = birthDate,
                    Team = new Team { Name = team },
                    CountryId = int.Parse(countryId)
                });
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult PlayerList()
        {
            var players = _dbContext.Players;
            
            return View(players);
        }
    }
}