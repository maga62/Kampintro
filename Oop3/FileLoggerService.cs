using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Oop3
{
    class FileLoggerService : ILogerServices
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
