using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.this关键字
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //对象1        
            Student student1 = new Student();
            student1.StudentId = 11;
            student1.Intro();

            //对象2
            Student student2 = new Student();
            student2.StudentId = 22;
            student2.Intro();
        }
    }
}
