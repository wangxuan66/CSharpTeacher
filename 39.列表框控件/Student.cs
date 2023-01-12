using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.列表框控件
{
    internal class Student
    {
        #region 构造函数
        public Student()
        {
        }
        public Student(int Id,string Name) 
        {
            StudentId = Id;
            StudentName = Name;
        }
        #endregion


        #region 属性
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        #endregion

    }
}
