namespace _26.构造函数的重载
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stu1 = new Student();

            Student stu2 = new Student(11);
            //当手动穿件一个有参数的构造函数时，你再次实例一个无参的构造函数时，编译器不会在自动创建，需要手动穿件一个无参的否则会报错
        }
    }
}