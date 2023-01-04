namespace _29.按钮控件详解
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*按钮控件属性
         * Text：界面所显示的文本
         * Name：程序内所按钮控件的名字
         * Enable：是否启用该按钮，默认为true，如果为false则无法点击
         * Click：当你点击时触发的事件
         * Mouse:这属于一类的事件是监测鼠标进入该控件等行为才会触发的事件
         */
        /// <summary>
        /// 点击事件
        /// </summary>
        private void BtnSayHi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你好，你点击了按钮控件！");
        }


        #region 鼠标移入超过3次时不提醒 ————作为进阶以及的内容理解流程就行
        int mouseNumber;

        /// <summary>
        /// 次数监测
        /// </summary>
        /// <param name="mouseNumber">进入次数</param>
        void MonitoringNumber(int mouseNumber)
        {
            if (mouseNumber > 3)//鼠标移入次数大于3则无操作
            {
                //超过3次我们就不需要提醒了，所以无需执行代码，为空即可
            }
            else
            {
                MessageBox.Show("鼠标进入了按钮控件！" + "当前鼠标移入次数为" + mouseNumber);
            }
        }
        #endregion 
        private void BtnSayHi_MouseEnter(object sender, EventArgs e)
        {
            mouseNumber++;//鼠标移入次数+1
            MonitoringNumber(mouseNumber);
        }
    }
}