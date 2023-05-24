using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    internal class Ex008
    {
        public void Run()
        {
            int kor = 100;
            int eng = 100;
            int math = 98;
            int ath = 97;

            int sum = kor + eng + math + ath;


            Console.WriteLine("{0}", sum);
            Console.WriteLine("{0}", (double)sum/4);
        }
    }
}
