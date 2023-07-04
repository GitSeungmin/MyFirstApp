using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Q002
{
    public void Run()
    {
        byte number;
        Console.Write("숫자를 입력하세요: ");
        try
        {
            number = Convert.ToByte(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}