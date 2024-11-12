using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TampaPremierLeague.Models;

namespace TampaPremierLeague.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var matches = new List<Match>
        {
            new Match { MatchId = 35, TeamOne = "Team1", TeamTwo = "Team4", MatchTime = DateTime.Now },
            new Match { MatchId = 36, TeamOne = "Team8", TeamTwo = "Team2", MatchTime = DateTime.Today.AddDays(1) },
            new Match { MatchId = 37, TeamOne = "Team3", TeamTwo = "Team5", MatchTime = DateTime.Today.AddDays(2) },
            new Match { MatchId = 38, TeamOne = "Team4", TeamTwo = "Team9", MatchTime = DateTime.Today.AddDays(2) },

        };

            return View(matches);
        }

        public IActionResult PointsTable()
        {

            var pointsTableViewModel = new PointsTableViewModel
            {
                Points = new List<TeamPoints>
            {
                new TeamPoints { Position = 1, TeamName = "Knights", Played = 8, Won = 7, Lost = 0, NoResult = 1, NetRunRate = 2.3880, Points = 30, RecentForm = "W W W W W" },
                new TeamPoints { Position = 2, TeamName = "Thunders", Played = 8, Won = 7, Lost = 1, NoResult = 0, NetRunRate = 2.7782, Points = 28, RecentForm = "W W L W W " },
                new TeamPoints { Position = 3, TeamName = "New Tampa Hawks", Played = 9, Won = 5, Lost = 2, NoResult = 2, NetRunRate = 1.0062, Points = 24, RecentForm = "L W L W W" },
                new TeamPoints { Position = 4, TeamName = "Tampa Telugu Titans", Played = 8, Won = 4, Lost = 2, NoResult = 2, NetRunRate = 1.5645, Points = 20, RecentForm = "W L L W W" },
                new TeamPoints { Position = 5, TeamName = "Revengers", Played = 9, Won = 4, Lost = 5, NoResult = 0, NetRunRate = 0.3939, Points =16, RecentForm = "W L L W L" },
                new TeamPoints { Position = 6, TeamName = "Tampa Pirates", Played = 8, Won = 3, Lost = 4, NoResult = 1, NetRunRate = 0.5748, Points = 14, RecentForm = "L W L L W" },
                new TeamPoints { Position = 7, TeamName = "Lazy Cricketers", Played = 9, Won = 3, Lost = 6, NoResult = 0, NetRunRate = -0.1357, Points = 12, RecentForm = "W L L W L" },
                new TeamPoints { Position = 8, TeamName = "Tampa Avengers", Played = 7, Won = 2, Lost = 4, NoResult = 1, NetRunRate = -1.5675, Points = 10, RecentForm = "W L L L W" },
                new TeamPoints { Position = 9, TeamName = "Tekinvaders", Played = 9, Won = 2, Lost = 7, NoResult = 0, NetRunRate = -2.3098, Points = 8, RecentForm = "L W L L L" },
                new TeamPoints { Position = 10, TeamName = "Tampa Shaheen", Played = 7, Won = 0, Lost = 6, NoResult = 1, NetRunRate = -5.4994, Points = 2, RecentForm = "L L L L W" },

            }
            };

            return View(pointsTableViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult DataModel()
        {
            return View();
        }
    }
}
