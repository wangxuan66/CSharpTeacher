namespace _28.窗体常用的方法和事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 窗体按钮操作
        /// <summary>
        /// 打开窗体
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            //form2.Show();//打开窗体
            form2.ShowDialog();//以对话框形式打开
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("确定关闭当前窗口吗？", "确认窗口", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //不关闭
            }

        }
        #endregion
        #region 窗体事件
        /// <summary>
        /// 点击关闭时触发
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        /// <summary>
        /// 窗体已经关闭后再触发
        /// </summary>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        /// <summary>
        /// 绘制窗体之前触发
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion


    }
}