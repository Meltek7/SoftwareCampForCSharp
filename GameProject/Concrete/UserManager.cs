using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserManager : IUserService
    {
        public void Add(User user)
        {
            Console.WriteLine("{0} {1} added!", user.Id, user.UserName);
        }

        public void Delete(User user)
        {
            Console.WriteLine("{0} {1} deleted!", user.Id, user.UserName);
        }

        public void Update(User user)
        {
            Console.WriteLine("{0} {1} updated!", user.Id, user.UserName);
        }
    }
}
