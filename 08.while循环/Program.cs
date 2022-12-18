using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.while循环
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //当我们使用if循环时，是能够清楚的知道，我们所需要进行循环的次数的，比如循环多少次，或者.length 、.count之类的
            //如果我们不知道需要循环的次数 ，我们就要用到while循环
            #region while循环

            int i = 0;
            int sum = 0;
            while (i<=36)
            {
                sum=sum + i;    
                i=i+1;    
            }
            Console.WriteLine("循环了{0}次，所有相加为{1}",i,sum);
            #endregion



            Console.ReadKey();
        }
    }
}
