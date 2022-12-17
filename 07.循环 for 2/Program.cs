using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.循环_for_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //使用for循环累加1-36
            //定义一个变量，存放累加的结果
            int sum = 0;
            for (int i = 0; i <= 36; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);//out666

        }
    }
}
