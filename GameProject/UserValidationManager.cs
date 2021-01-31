using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 1985 && gamer.FirstName =="Engin"
                && gamer.LastName == "Demiroğ" && gamer.IndentityNumber==12345)
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
