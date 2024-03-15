using BowlerAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BowlerAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerInfoController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlerInfoController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }
        [HttpGet]
        public IEnumerable<object> Get()
        {
            var joinedData = from Bowlers in _bowlerRepository.Bowlers
                             join Teams in _bowlerRepository.Teams on Bowlers.TeamID equals Teams.TeamID
                             select new JoinedBowler
                             {
                                 BowlerMiddleInit = Bowlers.BowlerMiddleInit,
                                 BowlerAddress = Bowlers.BowlerAddress,
                                 BowlerCity = Bowlers.BowlerCity,
                                 BowlerID = Bowlers.BowlerID,
                                 BowlerLastName = Bowlers.BowlerLastName,
                                 BowlerFirstName = Bowlers.BowlerFirstName,
                                 BowlerState = Bowlers.BowlerState,
                                 BowlerZip = Bowlers.BowlerZip,
                                 BowlerPhoneNumber = Bowlers.BowlerPhoneNumber,
                                 TeamID = Bowlers.TeamID,
                                 TeamName = Teams.TeamName
                             };
            return joinedData
                .Where(data => data.TeamName != null && (data.TeamName == "Marlins" || data.TeamName == "Sharks"))
                .ToList();

        }
    }
}
