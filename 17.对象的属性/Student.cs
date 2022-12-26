using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.对象的属性
{
    internal class Student
    {
        #region 类的成员字段
        /// <summary>
        /// 年龄
        /// </summary>
        // public int age;
        #endregion

        #region 设置属性
        private int age;
   
        /// <summary>
        /// 设置年龄
        /// </summary>
        public void SetAge(int ageValue)
        {
            if (ageValue > 0 && ageValue <= 100)
            {
                age = ageValue;
            }
            else
            {
                age = 0;
            }
        }
        /// <summary>
        /// 读取年龄
        /// </summary>
        /// <returns></returns>
        public int GetAge() 
        { 
            return age;
        }
        #endregion


        //看的出来使用手写属性是比较繁琐的所以我们可以使用内置的getset访问器来实现相同的功能
        //打出prop 然后按两下Tab键
        public string StudentName { get; set; }//这个就是属性，也叫全程为自动属性

        //属性与字段的区别是非常大的，字段可以理解为就是一个变量，但属性包含了get与set两个方法

        #region Demo
        public int StudentId { get; set; }
        #endregion
    }
}
