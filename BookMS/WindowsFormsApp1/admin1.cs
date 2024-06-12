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
    public partial class admin1 : Form
    {
        public admin1()
        {
            InitializeComponent();
        }

        private void 图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin2 admin = new admin2();
            admin.ShowDialog();
        }

        private void admin1_Load(object sender, EventArgs e)
        {

        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("找大佬帮忙");
        }

        private void 系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
