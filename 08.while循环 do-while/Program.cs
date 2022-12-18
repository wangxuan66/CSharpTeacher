using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.while循环_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //运行原理与while类似，但while循环会判断如不满足则不执行，但dowhile会先执行一次在进行判断是否满足条件
            //while循环：先判断再做事，do-while循环先执行再判断
            int i = 0;
            int sum = 0;

            do
            {
                sum += i;
                i++;
            } while (i<=36 );



            Console.ReadKey();
        }
    }
}
