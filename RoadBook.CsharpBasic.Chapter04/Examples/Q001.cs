using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    internal class Q001
    {
        public void Run()
        {
            Console.WriteLine("숫자를 입력해주세요");

            int number = Convert.ToInt32(Console.ReadLine());

            int fact = 1;
            for (int i = number; i > 0; i--){
                fact *= i;
            }

            Console.WriteLine("{0}! = {1}", number, fact);
        }
    }
}