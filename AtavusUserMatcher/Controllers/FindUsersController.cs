using Microsoft.AspNetCore.Mvc;
using AtavusUserMatcher.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System;
using AtavusUserMatcher.Models;
using System.Threading.Tasks;
using FuzzySharp;
using Microsoft.AspNetCore.Authorization;

namespace AtavusUserMatcher.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class FindUsersController : ControllerBase
    {
        private static readonly int MatchCount = 5;

        private readonly ILogger<FindUsersController> _logger;
        private readonly atavus_dbContext db;

        public FindUsersController(ILogger<FindUsersController> logger, atavus_dbContext db)
        {
            _logger = logger;
            this.db = db;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> FindUsers([FromBody] FindUsersParam data)
        {
            var users = await db.Users
                .Where(x => true)
                .Select(x => new UserMatch(x.Email, x.FirstName, x.LastName))
                .ToListAsync();

            List<UserMatchResult> results = new List<UserMatchResult>();
            foreach (var userToMatch in data.FailedImportUsers)
            {
                var result = new UserMatchResult()
                {
                    FailedImportUser = userToMatch,
                    Matches = new List<UserMatch>()
                };
                results.Add(result);

                foreach (var user in users)
                {
                    var score = Fuzz.Ratio(
                        userToMatch.Email + userToMatch.FirstName + userToMatch.LastName,
                        user.Email + user.FirstName + user.LastName);
                    if (result.Matches.Count < MatchCount)
                    {
                        var userToAdd = new UserMatch(user, score);
                        result.Matches.Add(userToAdd);
                        result.Matches = result.Matches.OrderByDescending(x => x.Score).ToList();
                    }
                    else if (score >= result.Matches.Last().Score)
                    {
                        var userToAdd = new UserMatch(user, score);
                        result.Matches.RemoveAt(MatchCount - 1);
                        result.Matches.Add(userToAdd);
                        result.Matches = result.Matches.OrderByDescending(x => x.Score).ToList();
                    }
                }
            }

            return Ok(new FindUsersResult() { Results = results });
        }

        public class FindUsersParam
        {  
            public List<FailedImportUser> FailedImportUsers {get; set;}
        }

        public class FindUsersResult
        {
            public List<UserMatchResult> Results {get; set;}
        }

        public class UserMatchResult
        {
            public FailedImportUser FailedImportUser {get; set;}
            public List<UserMatch> Matches {get; set;}
        }

        public class UserMatch
        {
            public UserMatch(string email, string firstName, string lastName)
            {
                Email = email;
                FirstName = firstName;
                LastName = lastName;
            }

            public UserMatch(UserMatch original, int score)
            {
                Email = original.Email;
                FirstName = original.FirstName;
                LastName = original.LastName;
                Score = score;
            }

            public string Email {get; set; }
            public string FirstName {get; set; }
            public string LastName {get; set; }
            public double Score { get; set; } = 0;
        }

        public class FailedImportUser
        {
            public string Email {get; set; }
            public string FirstName {get; set; }
            public string LastName {get; set; }
            public string Organization {get; set; }
            public string FailReason { get; set; }
        }
    }
}