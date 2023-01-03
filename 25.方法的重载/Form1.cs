namespace _25.方法的重载
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void SayHi()
        {
            MessageBox.Show("Hi!");
        }

        void SayHi(string name)
        {
            MessageBox.Show("Hi!" + name);
        }

        void SayHi(string name, int age)
        {
            MessageBox.Show("Hi!" + name + age);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SayHi();
            SayHi("Element");
            SayHi("Element",18);
        }
    }
}