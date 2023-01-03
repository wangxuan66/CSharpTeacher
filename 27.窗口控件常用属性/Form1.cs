namespace _27.窗口控件常用属性
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTest formTest = new FormTest();
            formTest.Show();
        }
    }
}