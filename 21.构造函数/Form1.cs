namespace _21.构造函数
{
    public partial class Form1 : Form//Form1继承自Form类
    {
        public Form1()//构造函数或者构造方法
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();//Student()这里就是调用他的构造函数

        }
    }
}