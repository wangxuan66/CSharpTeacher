using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.学生对象练手
{
    internal class Student
    {
        //类中可以拥有字段，也可以拥有方法。
        //如果想要外部能够访问得到 需要公开及public

        #region 类的成员字段
        /// <summary>
        /// 学生ID
        /// </summary>
        public int studentId;
        /// <summary>
        /// 学生姓名
        /// </summary>
        public string studentName;
        /// <summary>
        /// 学生年龄
        /// </summary>
        public int studentAge; 
        /// <summary>
        /// 学生性别
        /// </summary>
        public int studentGender;
        /// <summary>
        /// 学生身高
        /// </summary>
        public int studentHeight;
        /// <summary>
        /// 学生体重
        /// </summary>
        public int studentWeight;
        #endregion

        #region 类中的方法
        /// <summary>
        /// 自我介绍
        /// </summary>
        public void introduction() 
        {
            Console.WriteLine($"姓名为{studentName}");
            Console.WriteLine($"ID为{studentId}");
            Console.WriteLine($"年龄为{studentAge}");
            Console.WriteLine($"身高为{studentHeight}");
            Console.WriteLine($"体重为{studentWeight}");
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
