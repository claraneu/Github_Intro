using System;
using UML2_BigMamma;

public class Program 
{ 
    public static void Main(string[] args)
    {
        //Instantiate objects: Customer, Admin, Pizza, CustomerFile, PizzaMenu

        Customer jacobsen = new Customer("Toke Jacobsen", "tj@mail.com", "Toftebakkevej 9b, Valby","7852345");
        Customer neu = new Customer("Clara Neu", "cn@mail.com", "Toftebakkevej 9b, Valby", "123467");
        Customer poulsen = new Customer("Ole Poulsen", "op@mail.com", "Roshagevej 9, Vanløse", "76543");

        Admin luigi = new Admin("Luigi Schiavone", "lui@mail.com");

        Pizza pepperoni = new Pizza("Pepperoni", 59);
        Pizza marga = new Pizza("Margharita", 65);
        Pizza salami = new Pizza("Salami", 45);

        CustomerFile customerFile = new CustomerFile();

        PizzaMenu pizzaMenu = new PizzaMenu();



        //CustomerFile - CRUD OPERATIONS
            //add customers to customerFile

        customerFile.AddCustomer(jacobsen);
        customerFile.AddCustomer(neu);

            //print list of customers
        customerFile.PrintCustomerFile();

            //Search customer who does not exist
        Console.WriteLine(customerFile.SearchCustomer("Madeleine Jacobsen"));
        
            //Update customer
        customerFile.UpdateCustomer("Toke Jacobsen", "Toke Neu-Jacobsen", "tj2@mail.com", "Enghavevej 142", "29 29 29");

            //Remove customer
        customerFile.DeleteCustomer("Clara Neu");

            //Print updated list of customers
        customerFile.PrintCustomerFile();


        //PizzaMenu - CRUD Operations

            //Add pizzas to menu
        pizzaMenu.AddPizza(pepperoni);
        pizzaMenu.AddPizza(marga);
        pizzaMenu.AddPizza(salami);

        pizzaMenu.PrintMenu();

            //Search Pizza by ID
        pizzaMenu.SearchPizza(2);

            //Update
        pizzaMenu.UpdatePizza(3, "Spicy Salami", 67);

            //Delete
        pizzaMenu.DeletePizza(3);



    }

    EmmasClass emmasClass = new EmmasClass();
    

}