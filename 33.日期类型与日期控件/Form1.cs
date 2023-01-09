using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33.日期类型与日期控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.dateTimePicker1.Text);//读取dateTimePicker控件
            this.dateTimePicker1.Text = "2001/11/18";//写入dateTimePicker控件

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.textBox1.Text = this.monthCalendar1.SelectionStart.ToString();
        }
    }
}
