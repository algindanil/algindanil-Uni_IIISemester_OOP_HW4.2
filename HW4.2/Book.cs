using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4._2
{
    public class Book : Item
    {
        public Book()
        {
            this.Name = "";
            this.CountryOfOrigin = "";
            this.Price = 0;
            this.DateOfPackaging = DateTime.Now;
            this.Description = "";
            this.Publishing = "";
            this.Author = "";
            this.NumberOfPages = 0;
        }
        public Book(double price, string name, string country, DateTime date, string description, int noOfPages, string publishing, string author)
        {
            this.Price = price;
            this.Name = name;
            this.CountryOfOrigin = country;
            this.DateOfPackaging = date;
            this.Description = description;
            this.NumberOfPages = noOfPages;
            this.Publishing = publishing;
            this.Author = author;
        }
        public int NumberOfPages { get; set; }

        public string publishing = "";
        public string Publishing { get { return publishing; } set { publishing = value; } }
        
        public string author = "";
        public string Author { get { return author; } set { author = value; } }
    }
}
