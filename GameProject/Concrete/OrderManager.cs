using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class OrderManager : IOrderService
    {
        public void Sale(Order order)
        {
            Console.WriteLine("Game {0} saled to {1}", order.GameName, order.UserName);
        }
    }
}
