using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33.日期类型与日期控件
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);//现在的时间

            dateTime = dateTime.AddDays(1);//今日的时间+1天
            Console.WriteLine(dateTime);//输出明天

            dateTime = dateTime.AddDays(-1);//今日的时间-1天，就是昨日

            //ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}
