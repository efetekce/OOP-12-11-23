﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class VehicleLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Payment plan for vehicle loan has been calculated.");

        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
