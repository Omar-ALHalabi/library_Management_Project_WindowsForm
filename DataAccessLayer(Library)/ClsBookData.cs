using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_Library_;
using System.Diagnostics;
using System.Dynamic;

namespace DataAccessLayer__Book
{
    public class ClsBookData
    {
        static public DataTable GetAllBookInfo()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataSetting.librarydatabase);

            string query = "select * from books";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();

            }
            catch (Exception e)
            {
               // Console.WriteLine("error:" + e.Message);



            }
            finally
            {

                connection.Close();
            }




            return dt;

        }



        public static int AddNewBook( string title, string author, double price, int category, DateTime Date,int rate,string imagepath,int BookCopies)
        {
            int ID = -1;
             SqlConnection connection = new SqlConnection(ClsDataSetting.librarydatabase);

            string query = @"INSERT INTO [dbo].[Books]  ([Title] ,[Author] ,[Price],[category] ,[Date] ,[Rate],[imagepath],[BookCopies])  VALUES (@title,@author,@price,@category,@date,@rate,@imagepath,@BookCopies);
           select SCOPE_IDENTITY();";

           SqlCommand command = new SqlCommand(query, connection);

           // command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@author", author);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@category", category);
            command.Parameters.AddWithValue("@rate", rate);
            command.Parameters.AddWithValue("@date", Date);
            command.Parameters.AddWithValue("@BookCopies", BookCopies);
            if (imagepath != null)
            {
                command.Parameters.AddWithValue("@imagepath", imagepath);
            }
            else
            {
                command.Parameters.AddWithValue("@imagepath", System.DBNull.Value);

            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(),out int insertid))
                    {
                   ID = insertid;
                   }


            }
            catch (Exception ex)
            {
               // Console.WriteLine("Error: " + ex.Message);


            }
            finally
            {
                connection.Close();

            }


            return ID;




        }

        public static DataTable GetAllCategory()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataSetting.librarydatabase);
            string query = "select * from Category;";

            SqlCommand cmd = new SqlCommand(query,connection);
            

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();

            }
          
            finally
            {
                connection.Close();


            }


            return dt;


        }


        public static bool FindBookByID(ref int id, ref string title, ref string author, ref double price, ref int category, ref DateTime Date, ref  int rate, ref  string imagepath,ref int BookCopies)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(ClsDataSetting.librarydatabase);

            string query = "select * from Books where ID=@id";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", id);
         


            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    isfound = true;
                    title = (string)reader["title"];
                    author = (string)reader["author"];
                    price = (double)reader["price"];
                    category = (int)reader["category"];
                    Date = (DateTime)reader["date"];
                    rate = (int)reader["rate"];
                    BookCopies = (int)reader["BookCopies"];
                    if (reader["imagepath"]!=DBNull.Value)
                    {
                        imagepath = (string)reader["imagepath"];
                    }
                    else
                    {
                        imagepath = "";
                    }




                }
                else
                {
                    isfound = false;
                }

                reader.Close(); 




            }
            catch
            {
                isfound = false;


            }
            finally
            {
                connection.Close();


            }




            return isfound;





        }
       
        public static bool findcategorybyname(ref int id, ref string name)
        {
            bool isfound = false;

            SqlConnection connection =new SqlConnection(ClsDataSetting.librarydatabase);

            string query = "select * from Category where CategoryName=@name";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", name);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    isfound = true;
                    id = (int)reader["categoryid"];
                    name = (string)reader["categoryname"];




                }
                reader.Close();





            }
            catch
            {
                isfound = false;


            }
            finally
            {
                connection.Close();


            }




            return isfound;
        }

        public static bool  findcategorybyID(ref int id,ref string name)
        {
            bool isfound = false;
            
            SqlConnection connection = new SqlConnection(ClsDataSetting.librarydatabase);

            string query = "select * from Category where CategoryID = @id";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();      

                if(reader.Read())
                {
                    isfound = true;
                    id = (int)reader["categoryid"];
                    name = (string)reader["categoryname"];

                }


              
            }
            catch
            {
                isfound = false;
            }
            finally
            {
                connection.Close();

            }

            return isfound;

        }



        public static bool updateBookDetails(int id,string title, string author, double price, int category, DateTime Date,int rate,string imagepath, int BookCopies)
        {
            int rowaffacted = 0;

            SqlConnection connection = new SqlConnection(ClsDataSetting.librarydatabase);

            string query = @"UPDATE[dbo].[Books]
                            SET [Title] = @title,
                               [Author] = @author,
                               [Price] =@price,
                               [category] = @category,
                               [Date] =@date,
                               [Rate] = @rate,
                               [imagepath] =  @imagepath,
                                 [BookCopies]=@BookCopies
                             WHERE id = @ContactID"; ;

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@author", author);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@date", Date);
            cmd.Parameters.AddWithValue("@rate", rate);
            cmd.Parameters.AddWithValue("@ContactID", id);
            cmd.Parameters.AddWithValue("@BookCopies", BookCopies);
            if (imagepath != null && imagepath!="")
            {
                cmd.Parameters.AddWithValue("@imagepath", imagepath);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            }

            try
            {
                connection.Open();

                rowaffacted = cmd.ExecuteNonQuery();
               

                
            }
            catch
            {

                return false;

            }
            finally
            {

                connection.Close();
            }


            return (rowaffacted > 0);



        }


        public static  bool DeleteBook(int id)
        {
            int rowaffacted =0;
            SqlConnection connection = new SqlConnection(ClsDataSetting.librarydatabase);

            string query = "DELETE FROM [dbo].[Books]   WHERE ID=@id";

            SqlCommand cmd=new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@id", id);


            try
            {

                connection.Open();

                rowaffacted = cmd.ExecuteNonQuery();


            }
            catch
            {


            }
            finally
            {

                connection.Close();
            }





            return (rowaffacted>0);
        }


        public static bool findBookByName(ref int id, ref string title, ref string author, ref double price, ref int category, ref DateTime Date, ref int rate, ref string imagepath,ref int BookCopies)
        {
            bool isfound = false;
            SqlConnection connection = new SqlConnection(ClsDataSetting.librarydatabase);

            string query = "select * from Books where Title=@title";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@title", title);
          
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;
                    id = (int)reader["ID"];
                    author = (string)reader["author"];
                    price = (double)reader["price"];
                    category = (int)reader["category"];
                    Date = (DateTime)reader["date"];
                    rate = (int)reader["rate"];
                    BookCopies = (int)reader["BookCopies"];
                    if (reader["imagepath"] != DBNull.Value)
                    {
                        imagepath = (string)reader["imagepath"];
                    }
                    else
                    {
                        imagepath = "";
                    }

                }
                reader.Close();


            }
            catch
            {

                isfound = false;

            }
            finally
            {

                connection.Close();
            }


            return isfound;

        }



        public static bool AddCategory(string name)
        {
            int rowaffacted = 0 ;
            SqlConnection connection = new SqlConnection(ClsDataSetting.librarydatabase);

            string query = @"INSERT INTO [dbo].[Category] ([CategoryName]) VALUES  (@name);";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", name);

            try
            {
                connection.Open();
                rowaffacted = cmd.ExecuteNonQuery();

               

            }
            catch
            {
                rowaffacted = 0;


            }
            finally
            {
                connection.Close();

            }


            return rowaffacted>0;


        }





        public static bool DeleteCategory(string name)
        {
            int rowaffacted=0;
            SqlConnection connection = new SqlConnection(ClsDataSetting.librarydatabase);

            string query = @"DELETE FROM [dbo].[Category] WHERE CategoryName=@name";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", name);

            try
            {
                connection.Open();
               rowaffacted = cmd.ExecuteNonQuery();


               

            }
            catch
            {
                rowaffacted = 0;


            }
            finally
            {
                connection.Close();

            }


            return rowaffacted>0;


        }
    }





}
