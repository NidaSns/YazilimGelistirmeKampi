﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBes
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 1985 && gamer.FirstName == "ENGİN" && gamer.LastName == "DEMİROĞ" && gamer.IdetityNumber == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
