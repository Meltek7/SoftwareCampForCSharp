using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class CreditApplicationManager
    {
        public void GetApplication(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }

        public void CreditEvaluation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
