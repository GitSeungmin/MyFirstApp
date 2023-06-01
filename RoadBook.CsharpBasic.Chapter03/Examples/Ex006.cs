using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    internal class Ex006
    {
        public void Run()
        {
            Console.WriteLine("숫자를 입력하세요");
            String num1 = Console.ReadLine();
            int convertnum = Convert.ToInt32(num1);

            if (convertnum > 0)
            {
                Console.WriteLine("양수입니다.");
            }

            else if (convertnum < 0)
            {
                Console.WriteLine("음수입니다.");
            }

            else
            {
                Console.WriteLine("zero입니다.");
            }

            if (convertnum%2 == 0)
            {
                Console.WriteLine("짝수입니다.");
            }

            else //else if (convertnum % 2 != 0)
            {
                Console.WriteLine("홀수입니다.");
            }
        }
    }
}
