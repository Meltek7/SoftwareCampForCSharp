using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " Eklendi. Müşteri Numarası : " + customer.ID);
        }

        public void  Update(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " Güncellendi. Müşteri Numarası : " + customer.ID);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " Silindi.");
        }

        public void GetList(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ID + " Numaralı Müşteri:" + customer.Name + " " + customer.Surname);
            }
        }
    }
}
