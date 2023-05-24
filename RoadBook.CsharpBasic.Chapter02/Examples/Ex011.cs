using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    internal class Ex011
    {
        int globalValue = 20;

        public void Run()
        {
            int localValue = 10;

            Sum();
            Multiple();

            Console.WriteLine("local : {0} / global : {1}", localValue, globalValue); //localValue = 10, globalValue = 60
        }

        private void Sum()
        {
            globalValue = globalValue + 10; //globalValue = 20 + 10 = 30
        }

        private void Multiple()
        {
            globalValue = globalValue * 2; //globalValue = 30 * 2 = 60
        }
    }
}
