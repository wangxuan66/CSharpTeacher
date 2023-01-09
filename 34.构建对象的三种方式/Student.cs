using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.构建对象的三种方式
{
    internal class Student
    {
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Student() { }

        /// <summary>
        /// 有参构造函数
        /// </summary>
        /// <param name="Id">学生ID</param>
        /// <param name="Name">学生姓名</param>
        /// <param name="Age">学生年龄</param>
        public Student(int Id, string Name, int Age) 
        {
            this.StudentId = Id;//传进来的参数Id，赋值给属性
            this.StudentName = Name;
            this.StudentAge = Age;
        }

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
    }
}
