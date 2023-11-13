using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class EmergencyLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Payment plan for emergency loan has been calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
