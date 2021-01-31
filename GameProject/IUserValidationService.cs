using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserValidationService
    {   //True False şeklinde çalışacağım için void değilde bool olarak yazdım(Tabi ki bunu UserValidationManager in içindeki metotdada böyle yazdım) 
        bool Validate(Gamer gamer);
    }
}
