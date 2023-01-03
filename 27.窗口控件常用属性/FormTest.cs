using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27.窗口控件常用属性
{
    public partial class FormTest : Form
    {

        /*窗体的常用属性
         * Name：指代窗体的名字
         * KeyPreview:开启之后AcceptButton和CancelButton才能够起作用
         * AcceptButton：在窗体上按下回车，会触发相应的按钮点击事件
         * CancelButton：在窗体上按下ESC，会触发相应的按钮点击事件
         * BackColor：背景色
         * BackGroundImage：背景图片
         * FormBorderStyle：
         *                  None无边框、
         *                  FixedSingle固定窗体大小（需要配合禁用最大化、最小化按钮）、
         *                  Fixed3D固定窗体大小（需要配合禁用最大化、最小化按钮）、让窗体富有层次感、
         *                  FixedDialog标题旁边的图标消失，固定窗体大小
         *Opacity：不透明度（默认为100%不透明）
         *ShowIcon:显示标题栏小图标
         *ShowInTaskbar：是否显示在电脑桌面任务栏
         *StartPosition：窗体启动的位置
         *Text：窗体的标题文字
         *TopMost：窗体是否置顶显示
         *WindowState：表示窗体状态最大化、最小化、以及正常
         */
        public FormTest()
        {
            InitializeComponent();
        }

    }
}
