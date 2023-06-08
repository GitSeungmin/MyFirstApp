using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    internal class Q002
    {
        public void Run()
        {

            Random r = new Random();
            int que = r.Next(1, 50);
            int ans = 0;

            Console.WriteLine("1~50 사이의 특정 숫자를 맞춰보세요");
            do
            {
                ans = Convert.ToInt32(Console.ReadLine());

                if (que != ans)
                {
                    Console.WriteLine("틀렸습니다. {0}!", que > ans ? "UP" : "DOWN");
                }

            } while (que != ans);

            Console.WriteLine("정답입니다");
        }
    }
}