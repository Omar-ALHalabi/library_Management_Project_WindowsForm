using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_Library_
{
    public class ClsLogginScreen
    {
        static public DataTable GetAllInfoUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection connention = new SqlConnection(ClsDataSetting.librarydatabase);

            string query = "select * from loginScreen";

            SqlCommand cmd=new SqlCommand(query,connention);

            try
            {
                connention.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    dt.Load(reader);

                }

                reader.Close();


            }
            catch
            {

            }
            finally
            {
                connention.Close();
            }


            return dt;


        }

        static public bool AddUsers(string username,string password)
        {
            int rowaffacted = 0;
            SqlConnection connention = new SqlConnection(ClsDataSetting.librarydatabase);

            string query = "INSERT INTO [dbo].[LoginScreen] ([UserName] ,[Password]) VALUES (@username,@password)";

            SqlCommand command = new SqlCommand(query, connention);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);


            try
            {
                connention.Open();


                rowaffacted = command.ExecuteNonQuery();

            }
            catch {


                return false;
            }
            finally
            {

                connention.Close();
            }


            return rowaffacted > 0;

        }

      static public bool UpdateUser(string oldusername,string newusername,string password)
        {
            int rowaffacted = 0;
            SqlConnection connention = new SqlConnection(ClsDataSetting.librarydatabase);
            string query = "update LoginScreen set[UserName]=@newusername,[password]=@password where username =@oldusername";
            SqlCommand cmd = new SqlCommand(query, connention);
            cmd.Parameters.AddWithValue("@oldusername", oldusername);
            cmd.Parameters.AddWithValue("@newusername", newusername);
            cmd.Parameters.AddWithValue("@password",password);
          


            try
            {
                connention.Open();


                rowaffacted = cmd.ExecuteNonQuery();

            }
            catch
            {


                return false;
            }
            finally
            {

                connention.Close();
            }


            return rowaffacted > 0;


        }


    }
}
