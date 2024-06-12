using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class UesrReg : Form
    {
        public UesrReg()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=""&&textBox2.Text!=""&&textBox3.Text!=""&&textBox4.Text!="")
            {
                Dao dao = new Dao();
                string sql = $"insert into t_user values('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}')";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                
            }
            else
            {
                MessageBox.Show("输入不允许有空");
            }
        }
        }
    }

