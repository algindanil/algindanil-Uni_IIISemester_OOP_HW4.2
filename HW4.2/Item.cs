using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4._2
{
    public class Item
    {
        public Item() 
        {
            this.Name = "";
            this.CountryOfOrigin = "";
            this.Price = 0;
            this.DateOfPackaging = DateTime.Now;
            this.Description = "";
        }
        public Item(double price, string name, string country, DateTime date, string description)
        {
            this.Price = price;
            this.Name = name;
            this.CountryOfOrigin = country;
            this.DateOfPackaging = date;
            this.Description = description;
        }
        public double Price { get; set; }
        public string Name { get; set; }
        public string CountryOfOrigin { get; set; }
        public DateTime DateOfPackaging { get; set; }
        public string Description { get; set; }
    }
}
