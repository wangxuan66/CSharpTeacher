namespace _30.文本框控件详解
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*文本框控件
        * PassWordChar：可以让文本框作为密码框使用，输入 * 后，在改框输入的所有字符都变为*不在显示明文
        * Enable：不可输入或者点击
        * ReadOnly:不能输入内容，但是能够点击
        * MultiLine：多行显示
        * TextAlign：输入文字的对齐方式 靠左对齐、靠右对齐、居中对齐
        */

        /// <summary>
        /// 文本内容改变事件——TextChanged
        /// </summary>
        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("值改变");
        }
        /// <summary>
        /// 鼠标状态——鼠标离开文本框事件——MouseLeave
        /// </summary>
        private void TxtName_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("鼠标离开");
        }
    }
}