using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataAccessLayer__Book;

namespace businessLayer_library_
{
    public class clslibrary
    {
        enum enmode { add=0,update=1};

        enmode mode = enmode.add;
        public int id { get; set; }
        public string title  { get; set; }
        public string author { get; set; }
        public double price { get; set; }
        public int category { get; set; }
        public DateTime Date { get; set; }
        public int rate { get; set; }
        public int BookCopies { get; set; }
        public string imagepath { get; set; }



        public clslibrary()
        {
            this.id = -1;
            this.title = "";
            this.author = "";
            this.price = 0;
            this.category =-1;
            this.Date = DateTime.Now;
            this.rate = 0;
            this.BookCopies = 0;
            this.imagepath = "";

            mode = enmode.add;



        }

        public clslibrary(int id, string title, string author, double price, int category, DateTime Date, int rate, string imagepath, int BookCopies)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.price = price;
            this.category = category;
            this.Date = Date;
            this.rate = rate;
            this.BookCopies=BookCopies;
            this.imagepath = imagepath;

            mode = enmode.update;



        }


        public bool _AddNewBook()
        {

            this.id=ClsBookData.AddNewBook(this.title,this.author,this.price,this.category,this.Date,this.rate,this.imagepath,this.BookCopies);

            return this.id != -1;
        }

        static public clslibrary _FindBookByID(int id)
        {

            string title = "";
            string author="";
            double price = 0;
            int category = 0;
            DateTime Date = DateTime.Now;
            int rate = 0;
            int BookCopies=0;
            string imagepath = "";

            if(ClsBookData.FindBookByID(ref id, ref title, ref author, ref price, ref category, ref Date, ref rate, ref imagepath, ref BookCopies))
            {

                return new clslibrary(id, title, author, price, category, Date, rate, imagepath, BookCopies);


            }
            else
            {
                return null;
            }




        }

        static public DataTable _getBooksInfo()
        {

            return ClsBookData.GetAllBookInfo();

        }

         public bool _updateBookDetails()
        {
            return ClsBookData.updateBookDetails(this.id, this.title, this.author, this.price, this.category, this.Date, this.rate, this.imagepath,this.BookCopies);
            

               
            

        }

         public bool Save()
        {
            switch(mode)
            {
                case enmode.add:
                    {
                        if(_AddNewBook())
                        {
                            mode = enmode.update;
                            return true;

                        }
                        else
                        {
                            return false;
                        }

                    }
                case enmode.update:
                    {
                        return _updateBookDetails();
                    }
             
                 
                    

                       




                    
            }


            return false;
        }

        static public bool _DeleteBook(int id)
        {

            return ClsBookData.DeleteBook(id);



        }

        static public clslibrary _FindBookDetailsByName(string title)
        {
            int id=0;
            
            string author = "";
            double price = 0;
            int category = 0;
            DateTime Date = DateTime.Now;
            int rate = 0;
            int BookCopies=0;
            string imagepath = "";

            if(ClsBookData.findBookByName(ref id, ref title, ref author, ref price, ref category, ref Date, ref rate, ref imagepath,ref  BookCopies))
            {
                return new clslibrary(id, title, author, price, category, Date, rate, imagepath,BookCopies);



            }
            else
            {
                return null;
            }



        }




    }
}
