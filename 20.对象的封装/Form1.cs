namespace _20.对象的封装
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击添加学生信息
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
                Student stu = new Student();
                stu.StudentID = Convert.ToInt32(this.textBox1.Text);
                stu.StudentName = this.textBox2.Text;
                stu.StudentGender = this.comboBox1.Text;
                stu.StudentAge = Convert.ToInt32(this.textBox3.Text);

                MessageBox.Show($"学生信息为:{stu.StudentID}，{stu.StudentName}，{stu.StudentGender}，{stu.StudentAge}", caption: "信息确认");
        }
    }
}