using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class NewEStateUserValidationManager : IUserValidationService
    {
      //Eğer bir gün e devletteki doğrulama servisi değişirse diye bu class ı açtık

        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
