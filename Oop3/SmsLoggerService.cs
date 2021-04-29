using System;

namespace Oop3
{
    class SmsLoggerService : ILogerServices
    {
        public void Log()
        {
            Console.WriteLine("sms gönderildi ");
        }
    }
}
