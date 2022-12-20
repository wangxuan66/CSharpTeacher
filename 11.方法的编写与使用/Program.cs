using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;//所引用的类

namespace _11.方法的编写与使用  //访问空间名
{
    internal class Program//类名
    {
        static void Main(string[] args)//c#程序的主进程
        {
            #region 方法的概念
            //方法（函数）是一处编写，处处使用的很关键的东西，在c#程序中是很常见的代码构成
            //方法就是函数，函数就是方法无需区分，我们习惯叫什么就叫什么就行

            //结构：
            //可访问性 返回类型 方法名(参数列表)//1.如果不填写可访问性则默认为私有的 2.参数列表内可以不带参数但是（）符号是不可或缺的
            //{
            //    执行代码块;
            //}
            #endregion


            Program program = new Program();//我们的方法不是一个静态方法所以需要实例化Program这个类 .是成员访问符


            //      方法名  参数列表如果没有参数就带个（）最后结尾记得 ;  就调用这个方法了，如果不调用方法，是不会执行的
            program.SayHollow();//运行SayHollow这个方法
            Console.WriteLine("hollow,world！");

            //调用静态方法
            SayBay();

            //待返回值的方法调用
            int a = program.GetNumberFive();//谁调用这个方法就会返回给谁
            Console.WriteLine(a);

            //计算长方形的面积
            int b = program.GetRectangularArea(10, 20);
            Console.WriteLine($"长方形的长为10，宽为20所计算的面积为{b}");


            //输出你好+name参数
            program.GetNameHollo("Element");

            Console.ReadKey();
        }

        #region 无返回值 无参数方法
        void SayHollow()
        {
            Console.WriteLine("Hollow!");
        }
        //方法的代码块执行结束，后回到调用处继续执行
        #endregion

        #region 静态方法 关键词static
        static void SayBay()//使用static后调用该方法则不需要实例化这个类，因为会在生成期间就存在于内存当中
        {
            Console.WriteLine("baybay!");
        }
        #endregion

        #region 有返回值 无参数
        //带返回值时，返回类型void必须替换为你所需要返回的类型 如int string list等
        int GetNumberFive() //如果选择了返回类型则必须要return返回相同类型的数据，否则语法就会报错
        {
            return 5; //如果调用 GetNumberFive 这个方法，则会固定返回一个int类型的 5   
        }
        #endregion

        #region 有返回值有参数的方法
        /// <summary>
        /// 求长方形面积
        /// </summary>
        /// <param name="heigth">长</param>
        /// <param name="width">宽</param>
        /// <returns></returns>
        int GetRectangularArea(int heigth, int width)
        {
            return heigth * width;//返回长乘宽        
        }
        #endregion

        #region 无返回值 有参数方法
        /// <summary>
        /// 你好+姓名
        /// </summary>
        /// <param name="name"></param>
        void GetNameHollo(string name)
        {
            Console.WriteLine($"Hollo,{name}");
        }
        #endregion
    }
}
