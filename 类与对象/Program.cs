using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 类与对象;

namespace 类与对象
{
    internal class Program
    {

        static void Main(string[] args)          
        {
            #region 对象1
            Students stu1 = new Students();//创建一个新的学生对象，这个对象的名字是stu1
            stu1.studentId = 1;
            stu1.studentName = "stu1";
            #endregion

            #region 对象2
            Students stu2 = new Students();//创建一个新的学生对象，这个对象的名字是stu1
            stu1.studentId = 1;
            stu1.studentName = "element";
            #endregion


            Console.WriteLine($"对象1的学生ID为{stu1.studentId},他的姓名是{stu1.studentName};对象2的学生ID为{stu2.studentId},他的姓名是{stu2.studentName}。");
        }
    }
}
