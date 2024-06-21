using System;

namespace VsjAPI.Controllers
{
    public class Book
    {
     
            public String Bookname
            { get; set; }

        public String Subject
        { get; set; }

        public int Price
        { get; set; }

        
      

        public Book(string bookname, string subject, int price)
        {
            this.Bookname = bookname;
            this.Subject = subject;
            this.Price = price;
        }

        public override string? ToString()
        {
            return "BookName=" + Bookname + ", " + "Subject=" + Subject + ", " + "Price=" + Price;
        }
    }
    public class BookClassController
    {
    }
}
