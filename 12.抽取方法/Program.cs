using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _12.抽取方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //简单的输出
            string name = "Element";
            int age = 20;
            Console.WriteLine("我的名字是" + name + "，" + "我几年" + age + "岁了！");//使用字符串的拼接，因为使用的字符串拼接所以我们这里的age虽然是一个整型变量但还是把他当做字符串拼接了-这句话不理解也没有关系我们后面慢慢写代码会理解的 


            string name2 = "element";
            int age2 = 18;
            Console.WriteLine("我的名字是" + name2 + "，" + "我几年" + age2 + "岁了！");


            //根据上面写的可以发现每次自我介绍的时候都要声明变量，然后再次输出，所以我们考虑使用一个方法来简写
            Program program = new Program();
            program.Introduction("滴答",18);

        }


        /// <summary>
        /// 自我介绍
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="age">年龄</param>
        void Introduction(string name, int age)
        {
            Console.WriteLine("我的名字是" + name + "，" + "我几年" + age + "岁了！");
        }
    }
}
