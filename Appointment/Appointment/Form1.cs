
using MySql.Data.MySqlClient;
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


namespace Appointment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        bool visited = false;

        private void 登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();

        }

        private void textBox2_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))//如果不是输入数字就不让输入
            {
                e.Handled = true;
            }
        }



        private void textBox4_count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))//如果不是输入数字就不让输入
            {
                e.Handled = true;
            }
        }
        private void textBox4_count_TextChanged(object sender, EventArgs e)
        {
            int iMax = 3;//首先设置上限值
            if (textBox4_count.Text != null && textBox4_count.Text != "")//判断TextBox的内容不为空，如果不判断会导致后面的非数字对比异常
            {
                if (int.Parse(textBox4_count.Text) > iMax)//num就是传进来的值,如果大于上限（输入的值），那就强制为上限
                {

                    textBox4_count.Text = (iMax).ToString();
                }
            }
        }

        private void beginorder_button_Click(object sender, EventArgs e)
        {
            /*string M_str_sqlcon ="server=localhost;port=3306;user id=root;password=123456;database=test"; //根据自己的设置
            MySqlConnection mysqlcon = new MySqlConnection(M_str_sqlcon);
            mysqlcon.Open();*/
            visited = true;
        }

        private void endorder_button_Click(object sender, EventArgs e)
        {
            order_button.Hide();
        }

        private void order_button_Click(object sender, EventArgs e)
        {
            if (visited == true)
            {
                MySqlConnection mysqlcon = new MySqlConnection("server=localhost;database=test;user=root;port=3306;password=123456");
                mysqlcon.Open();

                string sql1 = "select count(*) from user where phone_num='" + textBox3_phone.Text + "'";
                MySqlCommand cmd1 = new MySqlCommand(sql1, mysqlcon);
                /*Int32 count = (Int32)cmd1.ExecuteScalar();*/
                int count = Convert.ToInt32(cmd1.ExecuteScalar());

                if (count > 0)
                {
                    string sql2 = "update user set name='" + textBox1_name.Text + "',ID_num='" + textBox2_id.Text + "',mask_num='" + textBox4_count.Text + "' where phone_num='" + textBox3_phone.Text + "'";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, mysqlcon);
                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    string sql = "insert into user (name,ID_num,phone_num,mask_num,subscribe) values('" + textBox1_name.Text + "','" + textBox2_id.Text + "','" + textBox3_phone.Text + "','" + textBox4_count.Text + "',0)";
                    MySqlCommand cmd = new MySqlCommand(sql, mysqlcon);
                    cmd.ExecuteNonQuery();
                }

                mysqlcon.Close();


            }
            else
            {
                MessageBox.Show("预约时间未到，请点击开启预约按钮");
            }

        }

    }
}
