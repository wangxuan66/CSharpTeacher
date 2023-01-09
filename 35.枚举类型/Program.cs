using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.枚举类型
{
    internal class Program
    {
        enum Gender//较为方便的规范开发
        {
            男,
            女,
            未知,
        }

        static void Main(string[] args)
        {
            //声明一个性别变量
            string gender = Gender.男.ToString();
            Console.WriteLine(gender);//OUT：男
        }
    }
}
