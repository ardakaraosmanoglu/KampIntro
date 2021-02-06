using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserManager userManager = new IUserManager(new UserValidationManager());
            userManager.Add(new User { Id = 1, BirthYear = 2000, FirstName = "Arda", LastName = "Karaosmanoğlu", InternationIdentityNumber = 12345 });
            userManager.Add(new User { Id = 2, BirthYear = 2000, FirstName = "Ozan", LastName = "Mavigözlü", InternationIdentityNumber = 12347 });

        }
    }
}
