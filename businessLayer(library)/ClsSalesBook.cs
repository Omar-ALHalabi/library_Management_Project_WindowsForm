using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataAccessLayer_Library_;

namespace businessLayer_library_
{
    public class ClsSalesBook
    {

        public int BookSalesID { get; set; }
        public int BookID { get; set; }
     
        public string Title { get; set; }
        public double price { get; set; }
        public DateTime Date { get; set; }
        public string category { get; set; }




        public ClsSalesBook()
        {
            this.BookSalesID = -1;
            this.BookID = -1;
            this.Title = "";
            this.price = 0;
            this.Date = DateTime.Now;
            this.category = "";
          
        }

        public ClsSalesBook(int BookSales, int BookID, int User, string Title, double price, DateTime Date, string category)
        {
            this.BookSalesID = BookSales;
            this.BookID = BookID;
            this.Title = Title;
            this.price = price;
            this.Date = Date;
            this.category = category;
     
        }


        public bool AddSaleBook()
            {

                  this.BookSalesID = SalesBooks._AddSaleBook( this.BookID, this.Title, this.price, this.Date, this.category);

                     return this.BookSalesID != -1;

            }



        public static DataTable GetAllInfo()
        {

            return SalesBooks._GetAllInfo();

        }
      

    }
}
