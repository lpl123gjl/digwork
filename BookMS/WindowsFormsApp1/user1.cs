using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class user1 : Form
    {
        public user1()
        {
            InitializeComponent();
            label1.Text = $"欢迎{Data.UName}登录";
        }

        private void 图书查看和借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user2 user = new user2();
            user.ShowDialog();
        }

        private void 当前借出图书和归还ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user3 user = new user3();
            user.ShowDialog();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HELP");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 联系管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请拨打管理员电话123456");
        }

        private void user1_Load(object sender, EventArgs e)
        {

        }
    }
}
