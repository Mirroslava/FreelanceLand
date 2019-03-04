using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FreelanceLand.Models;
using Backend.Services;
using Backend.Interfaces.ServiceInterfaces;
using Backend.DTOs;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetTopUsersController : ControllerBase
    {
        EFGenericRepository<User> userRepo = new EFGenericRepository<User>(new ApplicationContext());

        //Get Top 5
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetTopUsers()
        {
            ApplicationContext context = new ApplicationContext();
            List<FreelanceLand.Models.User> topfive1 = context.Users.OrderByDescending(t => t.Rating).Take(5).ToList();
            string[] topfive = new String[topfive1.Count];
            int i = 0;
            foreach (var val in topfive1)
            {
                topfive[i] = val.Name;
                i++;
            }
            return topfive;

        }
    }
}