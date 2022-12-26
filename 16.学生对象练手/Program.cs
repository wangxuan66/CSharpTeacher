using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.学生对象练手
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.studentName = "元素";//对象访问字段
            student1.studentId = 1;
            student1.studentHeight = 175;
            student1.studentWeight = 110;
            student1.introduction();//对象访问方法

            Console.WriteLine("-------------------------------------");

            Student student2 = new Student();
            student2.studentName = "小强";
            student2.studentId = 2;
            student2.studentHeight = 180;
            student2.studentWeight = 100;
            student2.introduction();
        }
    }
}
