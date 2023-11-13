
using System;
using System.Collections.Generic;

namespace UML2_BigMamma
{
    class PizzaMenu
    {
        public static Dictionary<int, Pizza> pizzaMenu = new Dictionary<int, Pizza>();

        // Print the whole menu
        public void PrintMenu()
        {
            Console.WriteLine("\n Here is your PizzaMenu:");
            foreach (var element in pizzaMenu)
            {
                Console.WriteLine($"Pizza ID: {element.Key}, Name: {element.Value}");
            }
        }

        // CRUD Methods

        // Add pizzas to the menu
        public void AddPizza(Pizza pizza)
        {
            pizzaMenu.Add(pizza.ID, pizza);
        }

        // Search pizza by ID

        public Pizza SearchPizza(int ID)
        {
            Console.WriteLine($"\n Pizza ID you searched for: {ID}");
            if (pizzaMenu.ContainsKey(ID))
            {
                Console.WriteLine(pizzaMenu[ID]);
                return pizzaMenu[ID];
            }

            Console.WriteLine("Pizza not found.");
            return null;
        }

        // Update Pizza

        public void UpdatePizza(int ID, string newName, double newPrice)
        {
            Pizza element = SearchPizza(ID);
            
            if (element != null) 
            {
                element.Name = newName;
                element.Price = newPrice;
                Console.WriteLine($"You've successfully updated Pizza {ID} to {element}");
                
            }

        }

        // Delete Pizza

        public void DeletePizza(int ID)
        { 
            Pizza element = SearchPizza(ID);
            if (element != null) 
            {
                pizzaMenu.Remove(ID);
                Console.WriteLine($"You deleted Pizza {element}");
            }
        }



    }
}
