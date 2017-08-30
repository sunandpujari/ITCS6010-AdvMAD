using InClass1API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InClass1API.Controllers
{
    public class UserController : ApiController
    {
        private readonly Func<IUserRepository> userRepository;

        public UserController(Func<IUserRepository> userRepository) {
            this.userRepository = userRepository;
        }

        [HttpPost]
        public bool SignUp(string name, int age, string Gender)
        {
            return true;
        }
    }
}
