namespace _31.随机数
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNumber_Click(object sender, EventArgs e)
        {
           //创建一个随即数对象
           Random random = new Random();
            //产生一个0——10的随机数，并且赋值给TextBox控件，来显示出来
           this.TxtBoxNumber.Text = Convert.ToString(random.Next(0, 10));//随机数遵循左开右闭原则
        }
    }
}