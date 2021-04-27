using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ConsumerLoan : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Consumer Loan");
        }
    }
}
