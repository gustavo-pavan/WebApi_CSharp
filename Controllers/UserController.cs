using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppRest.Context;
using WebAppRest.Models;

namespace WebAppRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private UserContext _db;

        public UserController(UserContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<User> Get()
        {
            return _db.Users.ToList();
        }


    }
}