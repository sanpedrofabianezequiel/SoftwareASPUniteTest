using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CheckValidYear:ValidationAttribute
    {

        public CheckValidYear()
        {
            ErrorMessage = "Debe ser mayor a 1598";
        }
        public override bool IsValid(object value)
        {
            //return base.IsValid(value);

            int year = (int)value;
            if (year < 1598)
            {
                return false;
            }
            else
            {
                return true;
            }

        }



    }
}