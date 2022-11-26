using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4._2
{
    public class GroceryItem : Item
    {
        public GroceryItem()
        {
            this.DueDate = DateTime.Now;
            this.Quantity = 0;
            this.Price = 0;
            this.Unit = "N/A";
            this.DateOfPackaging = DateTime.Now;
            this.Name = "N/A";
            this.CountryOfOrigin = "N/A";
            this.Description = "N/A";
        }

        public GroceryItem(double price, string name, string country, DateTime date, string description, DateTime dueDate, int quantity, string unit)
        {
            this.Price = price;
            this.Name = name;
            this.CountryOfOrigin = country;
            this.DateOfPackaging = date;
            this.Description = description;
            this.DueDate = dueDate;
            this.Quantity = quantity;
            this.Unit = unit;
        }
        public DateTime DueDate { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
    }
}
