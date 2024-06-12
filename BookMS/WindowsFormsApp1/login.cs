using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=" " && textBox2.Text!="")
            {
                Login();
            }
            else
            {
                MessageBox.Show("输入有空项，请重新输入");
            }
        }
        public void Login()
        {
            Dao dao = new Dao();

            if (radioButtonUser.Checked)
            {
                string sql = "select * from t_user where id = @id and psw = @psw";
                SqlCommand cmd = dao.command(sql);
                cmd.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@psw", textBox2.Text.Trim());

                IDataReader dc = cmd.ExecuteReader();

                if (dc.Read())
                {
                    Data.UID = dc["id"].ToString();
                    Data.UName = dc["name"].ToString();
                    MessageBox.Show("登录成功");
                    user1 user = new user1();
                    this.Hide();
                    user.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败");
                }

                dc.Close();
                dao.DaoClose();
            }
            else if (radioButtonAdmin.Checked)
            {
                string sql = "select * from t_admin where id = @id and psw = @psw";
                SqlCommand cmd = dao.command(sql);
                cmd.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@psw", textBox2.Text.Trim());

                IDataReader dc = cmd.ExecuteReader();

                if (dc.Read())
                {
                    MessageBox.Show("登录成功");
                    admin1 a = new admin1();
                    this.Hide();
                    a.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败");
                }

                dc.Close();
                dao.DaoClose();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UesrReg user = new UesrReg();
            user.ShowDialog();
        }
    }
}

