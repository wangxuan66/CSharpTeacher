using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace _34.构建对象的三种方式
{
    internal class Program
    {
        /*构建对象的三种常见方式
         * 1.先创建对象，然后对其各个属性赋值。  比较常用
         * 优点：逻辑容易控制
         * 缺点：如果属性较多 比较麻烦，而且赋值的时候容易重复
         * 
         * 2.对象初始化器
         * 优点：容易给每个属性赋值，没被赋值的属性也一目了然
         * 缺点：初始化代码内无法写逻辑判断
         * 
         * 3.使用构造函数
         * 优点：代码教为简洁,只需要传入参数即可
         * 缺点：参数太多时也不太方便
         */
        static void Main(string[] args)
        {
            #region 方法1
            //Student stu = new Student();
            //stu.StudentId = 01;
            //stu.StudentName = "Element";
            //int age = -18;//可以直接对外界给如的值进行判断(判断其合法性或者是否满足其要求)
            //if (age > 100 && age < 0)
            //{
            //    stu.StudentAge = age;
            //}
            //else
            //{
            //    stu.StudentAge = 0;
            //    Console.WriteLine("年龄不合法！");
            //}
            #endregion

            #region 方法2
            //Student stu2 = new Student()
            //{
            //    StudentId = 2,//注意使用对象初始化器，属性之间不能够使用 ; 应该使用 , 分隔
            //    StudentName = "wanghaha",
            //    StudentAge = 18,
            //    //    if (StudentAge > 0)//不能写逻辑，不然会报错
            //    //{

            //    //}
            //};//结束之后在使用 ; 结束语句
            #endregion

            #region 方法3
            Student stu3 = new Student(3,"小轩",20);
            #endregion
        }
    }
}
