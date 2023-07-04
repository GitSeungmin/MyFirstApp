using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter07.Works
{
    public class Q001
    {
        public int Run()
        {
            int number = 0;
            bool isError = false;

            Console.Write("숫자를 입력하세요: ");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                isError = true;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                isError = true;
            }
            finally
            {
                number = isError ? -1 : number;
            }

            return number;
        }
    }
}

