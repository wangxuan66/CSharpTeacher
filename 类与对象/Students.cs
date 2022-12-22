using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;//引用的命名空间

namespace 类与对象//namespace   命名空间  ，该项目的命名空间的名字是 ：类与对象
{
    internal class Students
    {


        private int a = 1;//私有访问权限
        public int b = 1;//公有访问权限



        /// <summary>
        /// 学生ID
        /// </summary>
        public int studentId { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        public string studentName { get; set; }
    }
}
