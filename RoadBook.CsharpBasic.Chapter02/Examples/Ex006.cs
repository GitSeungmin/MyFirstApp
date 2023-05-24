using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    internal class Ex006
    {
        public void Run()
        {
            sbyte shortByteNumber = 127;
            byte byteNumber = 0;
            short shortNumber = 32767;
            int intNumber = 20000;
            long longNumber = 50000;

            float floatNumber = 3.14f;
            double doubleNumber = 1.5;
            decimal decimalNumber = 5.5m;

            Console.WriteLine("정수 : {0}, {1}, {2}, {3}, {4}",
                shortByteNumber,
                byteNumber,
                shortNumber,
                intNumber,
                longNumber
                );

            Console.WriteLine("실수 : {0}, {1}, {2}",
                floatNumber,
                doubleNumber,
                decimalNumber
                );

            char ch = 'A';
            string strMessage = "Hello Csharp";

            Console.WriteLine(ch);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", strMessage[0], strMessage[1], strMessage[2],
                strMessage[3], strMessage[4]);

            bool bCalculate01 = (1 + 2 == 3);
            bool bCalculate02 = ((12 > 8) && (8 < 20));
            bool isContainsWord = "Hello Csharp".Contains("Hello");

            Console.WriteLine("1 + 2 = 3 ? ({0})", bCalculate01);
            Console.WriteLine("12는 8보다 크고 8은 20보다 작다? ({0})",
                bCalculate02);
            Console.WriteLine("Hello Csharp 문장에 Hello가 포함되어 있다? ({0})",
                isContainsWord);

            object objValue = 1;
            var vValue = "var";
            dynamic dValue = true;

            Console.WriteLine("object 변수 값은 {0}", objValue);
            Console.WriteLine("var 변수 값은 {0}", vValue);
            Console.WriteLine("dynamic 변수 값은 {0}", dValue);
        }
    }
}
