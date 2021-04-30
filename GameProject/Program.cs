using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new YeniEdevlet() );//eski edevlet UserValidateManager()
            gamerManager.Add(new Gammer
            {
                Id = 1,
                Birthyear = 1995,
                FirstName = "Muhammed",
                IndentityNumber = 123
            });
        }
    }
}
