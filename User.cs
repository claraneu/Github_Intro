using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2_BigMamma
{
    //superclass
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        //Constructor
        public User(string name, string email)
        {
            Name = name;
            Email = email;
      
        }

    }

    //subclasses - Everytime new object is instantiated, we increment id by 1
    public class Customer : User
    {
        //instance fields
        private static int nextId = 1;

        //Properties
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Id { get; set; }

        //Constructor
        public Customer(string name, string email, string address, string phone)
            : base(name, email)
        {
            Address = address;
            Phone = phone;
            Id = nextId++;
            
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()},{nameof(Name)}={Name}, {nameof(Email)}={Email},{nameof(Address)}={Address}, {nameof(Phone)}={Phone}}}";
        }
    }

    public class Admin : User
    {
        private static int nextId = 1;
        public int Id { get; set; }

        public Admin(string name, string email)
            : base(name, email)
        {
            Id = nextId++;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Email)}={Email}}}";
        }
    }

}
