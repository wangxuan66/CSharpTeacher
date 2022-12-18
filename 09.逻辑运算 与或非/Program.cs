using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.逻辑运算_与或非
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = 3 > 2;
            bool b = 2 > 4;

            #region 与逻辑  &&
            //需要两个条件都满足才为true

            //if (条件1 && 条件2 && 条件3)
            //{
            //    以上都条件成立才会执行该代码块代码，否则直接跳过
            //}



            //if (a&&b)//从这个demo中能够看到，需要a与b都为true，才会输出true否则为false，
            //{
            //    Console.WriteLine("true");
            //}
            //else { Console.WriteLine(false); }

            #endregion

            #region 或逻辑 ||
            //或逻辑 字需要两个条件里的一个为真，就输出true，否则为false

            //if (条件1 || 条件2 || 条件3)
            //{
            //    以上条件只要成立1个就会执行该代码块代码，如都不成立才跳过
            //}

            #endregion

            #region 逻辑非  !
            //if (条件成立)//这时候前面加上！可以将运算结果取反变为false
            //{

            //}

            int c = 0;
            int d = 2;

            if (c > d)
            {
                Console.WriteLine("c大于D");
            }
            else
            {
                Console.WriteLine("c小于D");
            }

            //对比组
            if (!(c > d))
            {
                Console.WriteLine("c大于D");
            }
            else
            {
                Console.WriteLine("c小于D");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
