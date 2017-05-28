using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            //LongRunningMethod();
            //LongRunningParallelMethod();
           

            Console.ReadLine();
        }

        public static void LongRunningMethod()
        {
            string s = "";
            for(int i=0;i<1000000;i++)
            {
                s = s + "Hello";
            }
        }

        

        public static void LongRunningParallelMethod()
        {
            string s = "";
            Parallel.For(0, 1000000, i =>
            {
                s = s + "Hello";
            });
        }
    }
}
