using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer__Book;

namespace businessLayer_library_
{
    public class ClsCategories
    {
        public int id { get; set; }
        public string categoryname { get; set; }
        
        public  ClsCategories(int id, string name)
        {
            this.id = id;
            this.categoryname = name;

        }

        static public DataTable _GetAllCategories()
        {

            return ClsBookData.GetAllCategory();


        }

       
        static public ClsCategories _FindCategoryByName(string name)
        {
            int id = -1;
            if(ClsBookData.findcategorybyname(ref id, ref name))
            {

                return new ClsCategories(id, name);


            }
            else
            {
                return null;

            }



        }


        //static  public  ClsCategories _FindCategoryByID(int id)
        // {
        //     string name = "";
        //    if( ClsBookData.findcategorybyID(ref id,ref name))
        //     {


        //         return new ClsCategories(id, name);
        //     }
        //     else
        //     {
        //         return null;
        //     }




        // }



        static public ClsCategories _FindCategoryByID(int id)
        {
            string name = "";

            if(ClsBookData.findcategorybyID(ref id, ref name))
            {

                return new ClsCategories(id, name);
            }
            else
            {
                return null;
            }
           
          


        }



        static public bool _AddCategory(string Category)
        {
            return ClsBookData.AddCategory(Category);
           


        }


        static public bool _DeleteCategory(string name)
        {
            return ClsBookData.DeleteCategory(name);


        }

    }
}
