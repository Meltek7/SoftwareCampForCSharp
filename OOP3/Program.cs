using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumerLoan consumerLoan = new ConsumerLoan();
            VehicleLoan vehicleLoan = new VehicleLoan();
            ICreditManager dwellingCredit = new DwellingCredit();


            CreditApplicationManager creditApplicationManager = new CreditApplicationManager();
            creditApplicationManager.GetApplication(consumerLoan, new DatabaseLoggerService());

            List<ICreditManager> credits = new List<ICreditManager>() {consumerLoan, dwellingCredit };

            //creditApplicationManager.CreditEvaluation(credits);

        }
    }
}
