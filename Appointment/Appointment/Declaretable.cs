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
                string sql = "(select subscribe from user where phone_num= '"+num+"')";
                MySqlCommand cmd = new MySqlCommand(sql, mysqlcon);
                int rdr =cmd.ExecuteNonQuery();
                if ( rdr >= 0 ) {
                    MessageBox.Show("用户在前三次预约中预约成功，不能再次预约");
                }
                else{
                    
                }