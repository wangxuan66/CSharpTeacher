using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.变量和方法在内存是如何操作的
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int a = 3;
            int b =GetNum(3);

            Console.WriteLine(a);//out：3
            Console.WriteLine(b);//out：4
            //由此可以看出两者之间普通的参数代入进去就是复制一份
        }

        /// <summary>
        /// 加一
        /// </summary>
        /// <param name="num">任意数</param>
        /// <returns></returns>
        static int GetNum(int num)
        {
            num = num + 1;
            return num;
        }

    }
}
