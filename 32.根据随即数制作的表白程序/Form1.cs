namespace _32.根据随即数制作的表白程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region 鼠标点击事件
        private void BtnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你！");
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("还是被你点到了，你在考虑下呗！");
        }
        #endregion

        #region 鼠标移动事件
        Random random = new Random();

        /// <summary>
        /// 鼠标随即移动位置
        /// </summary>
        void MouseRandomMove() 
        {
            #region 草稿
            //int MouseX;
            //int MouseY;
            //MouseX = random.Next(0, this.Size.Width);
            //MouseY = random.Next(0, this.Size.Height);
            #endregion

            //按钮横向的活动范围：窗体X轴（宽度）-按钮的宽度
            int MouseX = this.Size.Width - BtnNo.Width;
            //按钮纵向的活动范围：窗体Y轴（高度）-按钮的长度
            int MouseY = this.Size.Height - BtnNo.Height;



        }
        private void BtnNo_DragEnter(object sender, DragEventArgs e)
        {

        }
        #endregion

        //size是整个window的宽度和高度。clientsize是工作区的宽度和高度，去掉border和标题栏的宽度；size是整个窗体大小，clientsize是内框大小，也就是从窗口坐标原点算起。
        private void BtnNo_MouseEnter(object sender, EventArgs e)
        {
            #region 了解Form界面的宽高
            //Form的高
            MessageBox.Show(this.ClientSize.Height.ToString());
            //Form的宽
            MessageBox.Show(this.ClientSize.Width.ToString());
            #endregion
            MouseRandomMove();
        }
    }
}