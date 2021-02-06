using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.BirthYear == 2000 && user.FirstName == "Arda" && user.LastName == "Karaosmanoğlu" && user.InternationIdentityNumber == 12345)
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
