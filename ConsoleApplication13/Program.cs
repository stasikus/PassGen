using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                string myPassword = GUIDGen.GetGUID();
                Console.WriteLine(myPassword);
            }
            Console.ReadLine();
        }

        public static class GUIDGen
        {
            public static string GetGUID()
            {
                byte[] bytes = new Byte[16];
                RNGCryptoServiceProvider rand = new RNGCryptoServiceProvider();
                rand.GetBytes(bytes);
                Guid myGuid = new Guid(bytes);
                return myGuid.ToString().Replace("-", "").Trim();
            }
        }
    }
}
