using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NepalPayment.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string SameUserName { get; set; }
        [DataType(DataType.Password)]
        public string SamePassword { get; set; }
    }
}