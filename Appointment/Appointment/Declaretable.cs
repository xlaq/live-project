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