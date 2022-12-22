using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.学生对象练手
{
    internal class Student
    {
        #region 类中的属性
        /// <summary>
        /// 学生ID
        /// </summary>
        public int studentId { get; set; }
        /// <summary>
        /// 学生姓名
        /// </summary>
        public string studentName { get; set; }
        /// <summary>
        /// 学生年龄
        /// </summary>
        public int studentAge { get; set; }
        /// <summary>
        /// 学生性别
        /// </summary>
        public int studentGender { get; set; }
        /// <summary>
        /// 学生身高
        /// </summary>
        public int studentHeight { get; set; }
        /// <summary>
        /// 学生体重
        /// </summary>
        public string studentWeight { get; set; }
        #endregion

        #region 类中的方法
        public void inti() 
        {
            Console.WriteLine($"姓名为{studentName}");
            Console.WriteLine($"ID为{studentName}");
            Console.WriteLine($"年龄为为{studentName}");
        }

    #endregion

    #region 性别枚举后续使用
    /// <summary>
    /// 学生性别
    /// </summary>
    enum studentGender1
    {
        men,
        woman,
    }
    #endregion

}
}
