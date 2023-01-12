using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37.遍历集合中的元素
{
    internal class Country
    {
        public Country(){}

        public Country(int Id, string Name) 
        {
            this.CountryId = Id;
            this.CountryName = Name;
        }


        /// <summary>
        /// 国家ID
        /// </summary>
        public int CountryId { get; set; }
        /// <summary>
        /// 国家名称
        /// </summary>
        public string CountryName { get; set; }
    }
}
