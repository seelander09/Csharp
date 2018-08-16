using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ViewModelFun.Models
{
    public class Numbers
    {
        public Numbers()
        {

        }
        [RegularExpression("^[0-9]*$", ErrorMessage = "UPRN must be numeric")]
        public List<int> Val { get; set; }

    }
}
