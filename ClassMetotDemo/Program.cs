using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.ID = 1;
            customer1.Name = "Meltem";
            customer1.Surname = "Tekeli";
            customer1.CreateTime = DateTime.Now;
            customer1.Telephone = "11111111111";

            Customer customer2 = new Customer();
            customer2.ID = 2;
            customer2.Name = "Ferhat";
            customer2.Surname = "Akdağ";
            customer2.CreateTime = DateTime.Now;
            customer2.Telephone = "11122222222";

            Customer customer3 = new Customer();
            customer3.ID = 3;
            customer3.Name = "Defne";
            customer3.Surname = "Mina";
            customer3.CreateTime = DateTime.Now;
            customer3.Telephone = "33333333333";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();

            foreach (var customer in customers)
            {
                customerManager.Add(customer);
            }

            Console.WriteLine("-----------");

            customerManager.GetList(customers);

            Console.WriteLine("-----------");

            foreach (var customer in customers)
            {
                customerManager.Update(customer);
            }

            Console.WriteLine("-----------");

            foreach (var customer in customers)
            {
                customerManager.Delete(customer);
            }

            Console.ReadLine();

        }
    }
}
