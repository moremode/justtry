using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JustTry.Models
{
    public class User
    {
        public int Id { get; set; }

        public int Balance { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
