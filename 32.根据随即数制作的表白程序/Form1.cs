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
            this.Close();
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

            ////按钮横向的活动范围：窗体X轴（宽度）-按钮的宽度
            //int MouseX = this.Size.Width - BtnNo.Width;
            ////按钮纵向的活动范围：窗体Y轴（高度）-按钮的长度
            //int MouseY = this.Size.Height - BtnNo.Height;


            int X = this.ClientSize.Width - this.BtnNo.Width;//X的可移动距离就是工作区的宽减去按钮的宽，就是可活动范围的宽，下面的长也同理
            int Y = this.ClientSize.Height - this.BtnNo.Height;

            Random random = new Random();//创建XY随即数
            X = random.Next(0, X);
            Y = random.Next(0, Y);

            this.BtnNo.Location = new Point(X, Y);//按钮位置赋值

            //写法二只需要下面这一个行，就是省点代码量
            this.BtnNo.Location = new Point(random.Next(0,X), random.Next(0,Y));

        }
        #endregion


        /// <summary>
        /// 鼠标进入按钮事件
        /// </summary>
        ///Size是整个window的宽度和高度。clientsize是工作区的宽度和高度，去掉border和标题栏的宽度；size是整个窗体大小，clientsize是内框大小，也就是从窗口坐标原点算起。
        private void BtnNo_MouseEnter(object sender, EventArgs e)
        {
            #region 了解Form界面的宽高
            ////Form的高
            //MessageBox.Show(this.ClientSize.Height.ToString());//out：649
            ////Form的宽
            //MessageBox.Show(this.ClientSize.Width.ToString());//out：1178
            #endregion


            MouseRandomMove();


        }
    }
}