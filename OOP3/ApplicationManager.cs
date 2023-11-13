using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplicationManager
    {
        public void Apply(ICreditManager creditManager, ILoggerService loggerService)
        {
            //MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();
            //mortgageLoanManager.Calculate();

            creditManager.Calculate();
            loggerService.Log();
        }
        public void LoanInform(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }

        }
    }
}
