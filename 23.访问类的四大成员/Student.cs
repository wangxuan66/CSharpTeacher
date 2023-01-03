using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.访问类的四大成员
{
    internal class Student
    {
        public int StudentId;
        public string StudentName { get; set; }
        public void SayHi() 
        {
            MessageBox.Show("Hi!");
        }
    }
}
