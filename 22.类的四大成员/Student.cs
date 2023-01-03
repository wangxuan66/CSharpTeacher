using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*类的成员
 * 1.成员变量，我们又把他叫做字段
 * 2.属性
 * 3.方法
 * 4.构造函数，也叫做构造方法
 * 平时不常用的成员
 * 1.事件
 * 2.索引器
 */
namespace _22.类的四大成员
{
    internal class Student
    {
        public int StudentId;//字段

        public string StudentName { get; set; }//属性

        public void SayHI() //方法
        {
            Console.WriteLine("Hi！");
        }

        public Student()//构造函数
        {

        }

    }
}
