namespace _37.遍历集合中的元素
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 创建泛型集合
        /// </summary>
        private List<Country> ListCountry = new List<Country>();

        void AddCountry()
        {
            #region 对象1
            //这是根据Country类实例化出来的实体对象
            Country country1 = new Country()//创建Country的对象china
            {
                CountryId = 1,
                CountryName = "China"
            };

            ListCountry.Add(country1);//将这个对象放进ListCountry集合
            #endregion

            #region 对象2
            Country country2 = new Country();
            country2.CountryId = 2;
            country2.CountryName = "Japan";

            ListCountry.Add(country2);
            #endregion

            #region 对象3
            Country country3 = new Country(3, "USA") { };

            ListCountry.Add(country3);
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this.button1.Text = ListCountry.Count.ToString();

            //MessageBox.Show("卡流程弹窗");

            if (ListCountry.Count == 0)
            {
                AddCountry();
            }
            this.button1.Text = ListCountry.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCountry();

            if (ListCountry.Count == 0)
            {
                MessageBox.Show("未添加国家！");
            }
            else
            {
                #region 循环方法  for循环
                //for (int i = 0; i < ListCountry.Count; i++)
                //{
                //    MessageBox.Show(ListCountry[i].CountryName);
                //}
                #endregion

                #region 遍历方法 foreach
                //foreach (var item in ListCountry)//item是每次遍历到的Country,var是变量类型 item是它的变量名称
                //{
                //    MessageBox.Show(item.CountryName);
                //}
                #endregion

                #region 去掉遍历中的某一个元素
                Country country5 = new Country();
                country5.CountryName = "巴基斯坦";

                ListCountry.Add(country5);


                foreach (var item in ListCountry)//System.InvalidOperationException:“Collection was modified; enumeration operation may not execute.”
                {
                    if (item.CountryName == "巴基斯坦")
                    {
                        country5 = item;
                    }
                    ListCountry.Remove(country5);
                }
                MessageBox.Show(ListCountry.Count.ToString());
                #endregion
            }

        }
    }
}