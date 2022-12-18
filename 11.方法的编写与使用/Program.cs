using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;//所引用的类

namespace _11.方法的编写与使用  //访问空间名
{
    internal class Program//类名
    {
        static void Main(string[] args)//c#程序的主进程
        {
            //方法（函数）是一处编写，处处使用的很关键的东西，在c#程序中是很常见的代码构成
            //方法就是函数，函数就是方法无需区分，我们习惯叫什么就叫什么就行

            //结构：
            //可访问性 返回类型 方法名(参数列表)//1.如果不填写可访问性则默认为私有的 2.参数列表内可以不带参数但是（）符号是不可或缺的
            //{
            //    执行代码块;
            //}

            Program program= new Program();//我们的方法不是一个静态方法所以需要实例化Program这个类 .是成员访问符
            program.SayHollow();//运行SayHollow这个方法



            Console.ReadKey();
        }

        #region SayHollow方法
        //demo1：空返回值 空参数
        void SayHollow()
        {
            Console.WriteLine("Hollow!");
        }
        #endregion

    }
}
