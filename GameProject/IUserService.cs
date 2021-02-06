using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserService
    {
        void Add(User user);
        void Update(User user);
        void Remove(User user);

    }
}
