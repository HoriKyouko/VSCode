/*using System;

using System.Data;
using System.Data.SqlClient;

namespace database{
    class databaseExample{
        
        static string server = "97.74.229.216";
        static string database = "Northwind";
        static string uid = "sa";
        static string pwd = "Wash9Lives!";

        
        static void Main(string[] args){
            SqlConnection connection = new SqlConnection(String.Format("server={0};database={1};uid={2};pwd={3}", server, database, uid, pwd));

            
            try{
                connection.Open();

                /*SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SalesByCategory";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@CateoryName";
                parameter.SqlDbType = SqlDbType.NVarChar;
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = "Beverages";
                
                command.Parameters.Add(parameter);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()){
                    Console.WriteLine("{0}: {1:c}", reader[0], reader[1]);
                }
                reader.Close();*/

                /*string sql = "select @fn=FirstName, @ln=LastName from Employees where EmployeeID=2";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add("@fn", SqlDbType.NVarChar, 10);
                command.Parameters["@fn"].Direction = ParameterDirection.Output;
                command.Parameters.Add("@ln", SqlDbType.NVarChar, 20);
                command.Parameters["@ln"].Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
                
                string fn = command.Parameters["@fn"].Value.ToString();
                string ln = command.Parameters["@ln"].Value.ToString();*/

                /*string sql = "insert into Employees (FirstName, LastName) VALUES ('King','Tut') select @ID=@@IDENTITY";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add("@ID", SqlDbType.Int);
                command.Parameters["@ID"].Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();

                int ID = Convert.ToInt32(command.Parameters["@ID"].Value);
                int iii;
                iii=0;*/

                /*string sql = "select * from Employees";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read()){
                    string fn = reader["FirstName"].ToString();
                    string ln = reader["LastName"].ToString();
                    Console.WriteLine("{0} {1}", fn, ln);
                }
                reader.Close();
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message.ToString());
            }
            finally{
                if(connection.State == ConnectionState.Open){
                    connection.Close();
                }
            }
        }
    }
}*/