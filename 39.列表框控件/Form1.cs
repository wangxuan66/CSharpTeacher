namespace _39.列表框控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<Student> LStudent = new List<Student>() { new Student(11,"Element"), new Student(22, "xiaoxuan"), new Student(33, "EElement") };
        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.DataSource= LStudent;
            this.listBox1.DisplayMember= "StudentName";
            this.listBox1.ValueMember = "StudentId";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Text == ""|| this.listBox1.Text == null)
            {
                MessageBox.Show("数据源未绑定！");
            }
            else
            {
                MessageBox.Show(this.listBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.listBox1.SelectedValue.ToString() == "" || this.listBox1.SelectedValue.ToString() == null)
                {
                    MessageBox.Show("数据源未绑定！");
                }
                else
                {
                    MessageBox.Show(this.listBox1.SelectedValue.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("数据源绑定异常！");
            }
           

        }
    }
}