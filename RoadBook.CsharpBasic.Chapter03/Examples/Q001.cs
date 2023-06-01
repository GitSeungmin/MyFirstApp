using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    internal class Q001
    {
        public void Run()
        {
            Random rand = new Random();
            int randnum1 = rand.Next(1, 100);
            int randnum2 = rand.Next(1, 100);
            int result = randnum1 + randnum2;

            Console.WriteLine("{0} + {1}은?", randnum1, randnum2);
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == result)
            {
                Console.WriteLine("정답입니다");
            }

            else
            {
                Console.WriteLine("오답입니다");
            }
        }
    }
}
