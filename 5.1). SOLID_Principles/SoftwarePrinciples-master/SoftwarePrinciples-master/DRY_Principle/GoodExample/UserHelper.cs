﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY_Principle.GoodExample
{
    public class UserHelper
    {
        public static double GetUserCredit(double userCredit) 
        {
            return userCredit + 1000;
        }
    }
}
