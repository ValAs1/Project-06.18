using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static class RandomUtil
        {
            /// <summary>
            /// Get random string of 11 characters.
            /// </summary>
            /// <returns>Random string.</returns>
            public static string GetRandomString()
            {
                string path = Path.GetRandomFileName();
                path = path.Replace(".", ""); // Remove period.
                return path;
            }
        }
        
            static void Main()
            {
                // Test the random string method.
                Console.WriteLine(RandomUtil.GetRandomString());
                Console.WriteLine(RandomUtil.GetRandomString());
                Console.WriteLine(RandomUtil.GetRandomString());
                Console.WriteLine(RandomUtil.GetRandomString());
                Console.WriteLine(RandomUtil.GetRandomString());
            }
        

    }
}
