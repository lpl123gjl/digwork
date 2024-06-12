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
    public partial class admin2 : Form
    {
        public admin2()
        {
            InitializeComponent();
           

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void admin2_Load(object sender, EventArgs e)
        {
            Table();
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString()+ dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = "select * from t_book";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());


            }
            dc.Close();
            dao.DaoClose();
        }
        //书号查询
        public void TableID()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = $"select * from t_book where id ='{textBox1.Text}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());


            }
            dc.Close();
            dao.DaoClose();
        }

        public void TableName()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = $"select * from t_book where name like '%{textBox2.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());


            }
            dc.Close();
            dao.DaoClose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                label2.Text = id + dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除吗？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.OK)
                {
                    // 修正 SQL 查询语句拼写错误，并执行删除操作
                    string sql = $"delete from t_book where id='{id}'";

                    Dao dao = new Dao();
                    int result = dao.Execute(sql);

                    if (result > 0)
                    {
                        MessageBox.Show("删除成功");
                        Table();  // 刷新表格显示
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                    dao.DaoClose();
                }
            }
            catch
            {
                MessageBox.Show("请在表格中选要删除的图书记录","信息提示",MessageBoxButtons.OK,MessageBoxIcon.Error);// 异常处理
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin21 a = new admin21();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string author = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string press = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string number = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                admin22 admin = new admin22(id,name,author,press,number);
                admin.ShowDialog();
                Table();
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TableID();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            TableName();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Table();
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
