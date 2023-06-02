using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    internal class Ex002
    {
        public void Run()
        {
            const int number = 2;

            for(int index = 1; ;)
            {
                Console.WriteLine("{0} * {1} = {2}", number, index, number * index);

                if (index == 9)     // 2 * 9까지 출력 후 index가 9라면
                {
                    break;      // break
                }

                index += 1;     // index가 9가 아니라면 +1
            }
        }
    }
}
