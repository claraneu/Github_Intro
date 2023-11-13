using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2_BigMamma
{
    public class CustomerFile
    {
        public List<Customer> customers;

        //Constructor - create generic list
        public CustomerFile()
        {
            customers = new List<Customer>();
        }

        //Print list of customers

        public void PrintCustomerFile()
        {
            Console.WriteLine("\n Here is your Customer Database:");
            foreach (Customer customer in customers) 
            {
                Console.WriteLine(customer);
            }
        }

        //CRUD Methods
            //Add
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

            //Search 
        public Customer SearchCustomer(string customerName)
        {      
            foreach (Customer customer in customers)
            {
                if (customer.Name == customerName)
                {
                    return customer;
                }
            }

            Console.WriteLine($"\n Customer {customerName} not found.");
            return null; // If customer is not found
        }

            //Update

        public void UpdateCustomer(string CustomerName, string newName, string newEmail, string newAddress, string newPhone)
        {
            Customer customer = SearchCustomer(CustomerName); //Search customer by name

            if (customer != null) //Check if customer exists
            {
                customer.Name = newName;
                customer.Email = newEmail;
                customer.Address = newAddress;
            }
        }

            // Delete
        public void DeleteCustomer(string CustomerName) 
        {
            Customer customer = SearchCustomer(CustomerName);

            if (customer != null) 
            {
                customers.Remove(customer);
                Console.WriteLine($"\n You deleted customer {customer.Name}");
            }
        }

    }
}

