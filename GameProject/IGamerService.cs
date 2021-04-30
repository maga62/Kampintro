using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    interface IGamerService
    {
        void Add(Gammer gamer);
        void Update(Gammer gamer);

        void Delete(Gammer gamer);
    }
}
