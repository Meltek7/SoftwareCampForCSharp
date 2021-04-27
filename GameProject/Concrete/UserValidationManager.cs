using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.IdentityNumber == 123 && user.FirstName == "Meltem" && user.LastName == "Tekeli Akdağ" && user.BirthYear == 1994)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
