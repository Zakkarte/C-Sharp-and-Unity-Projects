﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbstract241
{
    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
            
        }
    }
}
