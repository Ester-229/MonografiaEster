using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2_.net_framework_.Models
{
    public class Login
    {
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}