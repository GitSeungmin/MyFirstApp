using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    internal class Q001
    {
        public void Run()
        {
            Console.WriteLine("첫 번째 숫자를 입력해 보세요!");

            string num1 = Console.ReadLine();
            Console.WriteLine("당신이 입력한 값은 {0}", num1);
            int convertNum1 = Convert.ToInt32(num1);

            Console.WriteLine("두 번째 숫자를 입력해 보세요!");

            string num2 = Console.ReadLine();
            Console.WriteLine("당신이 입력한 값은 {0}", num2);
            int convertNum2 = Convert.ToInt32(num2);

            bool result = (convertNum1 > convertNum2);
            Console.WriteLine("비교 결과: {0}", result);
        }
    }
}
