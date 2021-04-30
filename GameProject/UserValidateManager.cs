using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidateManager : IUserValidationService
    {
        public bool Validate(Gammer gamer)
        {
            if(gamer.Birthyear==1995 && gamer.FirstName=="Muhammed"&& gamer.IndentityNumber==123)
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
