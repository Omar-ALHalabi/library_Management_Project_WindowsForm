using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_Library_
{
    public class SalesBooks
    {

       static public int _AddSaleBook( int BookID, string Title, double price, DateTime Date, string category)
        {

            int id = -1;


            SqlConnection connection = new SqlConnection(ClsDataSetting.librarydatabase);

            string query = "INSERT INTO [dbo].[booksales] ([BookID],[title]  ,[price] ,[DateOfSale],[Category]) VALUES (@bookID,@Title,@price,@Date,@category);select SCOPE_IDENTITY();";

            SqlCommand cmd=new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@bookID", BookID);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@category", category);
          

            try
            {
                connection.Open();
                object result=cmd.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(),out int BookSaleID))
                {
                    id = BookSaleID;

                }

                


            }
            catch
            {

             


            }
            finally {
                connection.Close();

            }


            return id;
        }


        static public DataTable _GetAllInfo()
        {
            DataTable dt=new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataSetting.librarydatabase);

            string query = "select * from booksales;";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {

                    dt.Load(reader);
                }


            }
            catch
            {




            }
            finally
            {
                connection.Close();


            }

            return dt;





        }



    }
}
