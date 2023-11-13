using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2_BigMamma
{
    class Pizza
    {
        // Instance fields
        private static int idCounter = 1;
        

        // Constructor
        public Pizza(string name, double price)
        {
            ID = idCounter++; //this is to increment each new pizza ID with 1
            Name = name;
            Price = price;

        }

        //Properties

        public string Name
        { get; set; }

        public double Price
        { get; set; }

        public int ID
        { get; set; }

        //toString
        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Price)}={Price}, {nameof(ID)}={ID.ToString()}}}";
        }

        



    }
}
