using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NepalPayment.Models
{
    public class Register
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
       [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Address { get; set; }
    }
}