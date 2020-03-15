string M_str_sqlcon ="server=localhost;port=3306;user id=root;password=123456;database=mask"; //根据自己的设置
            MySqlConnection mysqlcon = new MySqlConnection(M_str_sqlcon);
            try{
                mysqlcon.Open();
                string sql = "update user set subscribe=subscribe-1";
                MySqlCommand cmd = new MySqlCommand(sql, mysqlcon);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex){
                Console.WriteLine(ex.Message);
            }
            finally{
                mysqlcon.Close();
            }
string M_str_sqlcon ="server=localhost;port=3306;user id=root;password=123456;database=mask"; //根据自己的设置
            MySqlConnection mysqlcon = new MySqlConnection(M_str_sqlcon);
            string num = textBox3_phone.Text;
            try{
                mysqlcon.Open();
                string sql = "(select subscribe from user where phone_num= '"+num+"')";//根据输入的手机号查询用户的预定计数
                MySqlCommand cmd = new MySqlCommand(sql, mysqlcon);
                int rdr =cmd.ExecuteNonQuery();
                if ( rdr >= 0 ) {//如果用户的预定计数大于0，则不能预约
                    MessageBox.Show("用户在前三次预约中预约成功，不能再次预约");
                }
                else{
                    sql = "(update user set subscribe=4 where phone_num= '"+num+"')";//如果成功预约就根据手机号把用户的预约计数设为4
                    MySqlCommand cmd1 = new MySqlCommand(sql, mysqlcon);
                    cmd.ExecuteNonQuery();
                }