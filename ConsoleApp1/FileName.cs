/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FileName
    {
        public static void Main(string[] args)
        {
            int passed = 0;
            int failed = 0;
            do
            {
                passed = 0;
                failed = 0;
                int i = 1;
                while (i <= 10)
                {
                    Console.WriteLine("Nhap result nguoi so {0} : ", i);
                    int result = Convert.ToInt32(Console.ReadLine());
                    if (result == 1)
                    {
                        passed++;
                    }
                    if (result == 2)
                    {
                        failed++;
                    }
                    i++;
                }
                Console.WriteLine("Number of passed: {0}", passed);
                Console.WriteLine("Number of failed: {0}", failed);
            } while (passed >= 8);
        }
    }
}
*/