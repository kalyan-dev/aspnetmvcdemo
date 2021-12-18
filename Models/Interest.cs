using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace aspnetmvcdemo.Models
{
    public class Interest
    {
        [Range(1000, Int32.MaxValue, ErrorMessage = "Amount must be min INR 1000.")]
        public int amount { get; set; }

        [Range(9, 50, ErrorMessage = "Invalid interest rate")]
        public int rate { get; set; }
        public int interest { get; set; }
    }
}