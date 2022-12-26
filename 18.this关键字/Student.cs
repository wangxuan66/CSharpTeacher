using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.this关键字
{
    internal class Student
    {

        public int StudentId { get; set; }

        public void Intro() 
        {
            Console.WriteLine(this.StudentId);//这个this指的是由这个类创建出来的对象也就是是对象的studentid


        }
    }
}
