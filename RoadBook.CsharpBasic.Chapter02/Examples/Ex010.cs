using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    internal class Ex010
    {
        public void Run()
        {
            string strNumber = "10";

            int convertNumber = Convert.ToInt32(strNumber); //Convert: 문자열 값이 Null인 경우 0 반환
            int parseNumber = Int32.Parse(strNumber); //Parse: 문자열 값이 Null인 경우 에러

            Console.WriteLine("{0} + {1} = {2}", convertNumber, parseNumber, convertNumber+parseNumber);
        }
    }
}
