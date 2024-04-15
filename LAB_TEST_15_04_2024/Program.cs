using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_TEST_15_04_2024
{
    public class Program
    {
        public static void Pow_Test(int x, int n) {
            if ((x >= 0 && x < 1000))
            {

                if ((n > 0 && n <= 100))
                {
                    Console.WriteLine("x в степени n = " + Math.Pow(x, n));
                }
                else {
                    Console.WriteLine("число n за пределами диапозона [1;100]");
                }
            }
            else {
                Console.WriteLine("число x за пределами диапозона [0;999]");
            }

        }

        public static void Test(string a, string b) {
            //Console.WriteLine("Введите число");
            int x;
            int n;
            if (int.TryParse(a, out x))
            {
                //Console.WriteLine("Введите степень");
                if (int.TryParse(b, out n))
                {
                    Pow_Test(x, n);
                }
                else { Console.WriteLine("не число"); }
            }
            else
            {
                Console.WriteLine("не число");
            }

        }


        public static void Main()
        {
            string a = "5";
            string b = "2";
            Test(a,b);
            Console.ReadKey();
        }
    }
}
