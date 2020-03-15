using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string M_str_sqlcon ="server=localhost;port=3306;user id=root;password=123456;database=test"; //根据自己的设置
            MySqlConnection mysqlcon = new MySqlConnection(M_str_sqlcon);
            mysqlcon.Open();
        }

        private void endorder_button_Click(object sender, EventArgs e)
        {
            string M_str_sqlcon = "server=localhost;port=3306;user id=root;password=123456;database=test"; //根据自己的设置
            MySqlConnection mysqlcon = new MySqlConnection(M_str_sqlcon);
            mysqlcon.Close();
        }
    }
}
