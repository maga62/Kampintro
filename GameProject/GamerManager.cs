using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    //gamer manager Microservice kullandı dışardan kayıt konrolu E devlet üzerinden oldu
    class GamerManager : IGamerService

    {
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gammer gamer)

        {
            if (this.userValidationService.Validate(gamer) == true) { 
                Console.WriteLine("kayıt olundu"); }
            else
            {
                Console.WriteLine("dogrulaam başarısız yeniden deneyiniz!");
            }
            
        }

        public void Delete(Gammer gamer)
        {
            Console.WriteLine("kayıt silindi");
        }

        public void Update(Gammer gamer)
        {
            Console.WriteLine("kayıt güncellendi");
        }
    }
}
