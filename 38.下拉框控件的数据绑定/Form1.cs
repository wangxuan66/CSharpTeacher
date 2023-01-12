namespace _38.下拉框控件的数据绑定
{
    public partial class Form1 : Form
    {
        private List<Country> LCounty = new List<Country>()//声明一个国家的泛型集合
        {
            new Country(){CountryId = 11,CountryName = "中国" },//对象的初始化器
            new Country(){CountryId = 22,CountryName = "巴基斯坦" },
            new Country(){CountryId = 33,CountryName = "俄罗斯" },
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox2.DataSource = LCounty;//将泛型集合内的数据给到comboBox2的数据源属性
            this.comboBox2.DisplayMember = "CountryName";//指定comboBox2要显示的内容
            this.comboBox2.ValueMember = "CountryId";
        }

        /// <summary>
        /// 显示当前comboBox2的国家名称
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.comboBox2.Text);
        }

        /// <summary>
        /// 显示当前comboBox2的国家ID
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.comboBox2.SelectedValue.ToString());
        }
    }
}