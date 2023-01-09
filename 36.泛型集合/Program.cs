using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.泛型集合
{
    /*泛型集合
     * List<类型> 类型名称 = new  List<类型>;//类型为存放的数据类型，类型名称可理解为变量名,new后面的为构造函数
     * 
     * ListStr.Add(要添加的对象);
     * 
     * ListStr.Insert(a,b);
     * 
     * 下标是从0开始的，取元素也是根据下标的
     * List<下标>
     * 
     * 修改元素
     * List[下表] = 值;
     * 
     * 删除元素
     *List.Remove(数据名);
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "abc";//排序是从0开始的
            string b = "def";
            string c = "ghi";


            List<string> ListStr = new List<string>();
            //添加数据
            ListStr.Add(a);//将数据放入泛型集合
            ListStr.Add(b);
            ListStr.Add(c);

            //插入数据
            string d = "xxx";//我想把d这个数据插入到 a和b之间
            ListStr.Insert(1,d);

            //取数据
            Console.WriteLine(ListStr[0]);

            //修改数据
            ListStr[0] = "123";
            Console.WriteLine(ListStr[0]);

            //删除
            ListStr.Remove(a);

            #region 草稿-无移除效果
            //ListStr[0].Remove(1);
            //for (int i = 0; i < ListStr.Count; i++)
            //{
            //    Console.WriteLine(ListStr[i]);
            //}
            #endregion

        }
    }
}
