using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //Microsrvice
    class GamerManager : IGamerService
    {
        //Eğer bir manager sınıfını başka bir manager sınıfında kullanacaksan asla onu newleme onun yerine şunu yap:

        IUserValidationService _userValidationService;  //bunu yazdıktan sonra yazını üstüne dokunup ampulden generate constractor dedik

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Added");

            }
            else
            {
                Console.WriteLine("Verification failed.Registration failed");
                
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Registration deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Registry updated");
        }
    }
}
