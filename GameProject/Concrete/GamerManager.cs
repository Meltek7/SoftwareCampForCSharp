using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("{0} {1} added!", gamer.Id, gamer.UserName);
            }
            else
            {
                Console.WriteLine("Validation failed!");
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("{0} {1} deleted!", gamer.Id, gamer.UserName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("{0} {1} updated!", gamer.Id, gamer.UserName);
        }
    }
}
