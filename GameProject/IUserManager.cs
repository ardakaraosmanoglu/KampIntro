using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class IUserManager : IUserService
    {
        IUserValidationService _userValidationService;
        public IUserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(User user)
        {
            if (_userValidationService.Validate(user) == true)
            {
                Console.WriteLine("Oyuncu kayıt edildi.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt yapılamadı.");
            }
        }

        public void Remove(User user)
        {
            Console.WriteLine("Oyuncu silindi.");
        }

        public void Update(User user)
        {
            Console.WriteLine("Oyuncu güncellendi.");
        }
    }
}
