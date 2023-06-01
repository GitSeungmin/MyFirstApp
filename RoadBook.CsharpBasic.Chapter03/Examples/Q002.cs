using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    internal class Q002
    {
        public void Run()
        {
            Console.WriteLine("중간고사 점수를 입력하세요");
            int midscore = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("기말고사 점수를 입력하세요");
            int finscore = Convert.ToInt32(Console.ReadLine());
            int average = (midscore + finscore) / 2;

            if (average >= 90)
            {
                Console.WriteLine("A학점 입니다.");
            }

            else if (average < 90 && average >= 80)
            {
                Console.WriteLine("B학점 입니다.");
            }

            else if (average < 80 && average > 70)
            {
                Console.WriteLine("C학점 입니다.");
            }

            else if (average < 70 && average >= 0)
            {
                Console.WriteLine("F학점 입니다.");
            }

            else
            {
                Console.WriteLine("입력이 잘못되었습니다.");
            }
        }
    }
}
