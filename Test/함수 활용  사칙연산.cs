using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_04
{
    internal class Program
    {
        static int plus(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.Write("숫자 입력1 : ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("숫자 입력2 : ");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.Write($"{num1} + {num2} = {plus(num1, num2)}");
        }
    }
}
