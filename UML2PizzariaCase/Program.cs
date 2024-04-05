using System.ComponentModel.DataAnnotations;

namespace UML2PizzariaCase
{
    internal class Program
    {
        static List<Customer> customers = new List<Customer>();
        static List<Pizza> pizzas = new List<Pizza>();
        static List<Order> orders = new List<Order>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Big Mamma Pizzaria's new and upgraded ordering system!");

            static void PizzaMenuAdministration()
            {
                while (true)
                {
                    Console.WriteLine("\nPlease select any of the following options to continue:");
                    Console.WriteLine("1.) Pizza Menu Administration");
                    Console.WriteLine("2.) Customer Administration");
                    Console.WriteLine("3.) Order Administration");
                    Console.WriteLine("4.) Exit Program");
                    Console.Write("Select your choice by entering the number:");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            AddPizzaToMenu();
                            break;
                        case "2":
                            DeletePizzaFromMenu();
                            break;
                        case "3":
                            UpdatePizzaOnMenu();
                            break;
                        case "4":
                            PrintOrders();
                            break;
                        case "5":
                            return;
                        default:
                            Console.WriteLine("Sorry, that is not on the menu. Please try again.");
                            break;
                    }
                }
            }
            void AddPizzaToMenu(Pizza pizza)
            {
                pizzas.Add(pizza);
            }

            void DeletePizzaFromMenu(int pizzanumber)
            {
                Pizza pizzaDelete = pizzas.Find(p => pizzanumber == pizzanumber);
                if (pizzaDelete != null)
                    pizzas.Remove(pizzaDelete);
            }

            void UpdatePizzaOnMenu(int pizzanumber, Pizza updatedPizza)
            {
                Pizza pizzaToUpdate = pizzas.Find(p => pizzanumber == pizzanumber);
                if (pizzaToUpdate != null)
                {
                    pizzaToUpdate.Name = updatedPizza.Name;
                    pizzaToUpdate.Toppings = updatedPizza.Toppings;
                    pizzaToUpdate.Price = updatedPizza.Price;
                    // Why are these marked as red
                }
            }
            static void PrintOrders()
            {
                Console.WriteLine("\nList of Orders:");
                foreach (var order in orders)
                {
                    Console.WriteLine($"Order Number: {order.OrderNumber}, Customer: {order.Customer.Name}");
                    Console.WriteLine("Pizzas:");
                    foreach (var pizza in order.Pizzas)
                    {
                        Console.WriteLine($"- {pizza.Name}");
                    }
                }
            }
            static void OrderAdministration()
            {
                while (true)
                {
                    Console.WriteLine("\nOrder Administration Menu:");
                    Console.WriteLine("1. Create a new order");
                    Console.WriteLine("2. Delete an order");
                    Console.WriteLine("3. Update an order");
                    Console.WriteLine("4. Print out the list of orders");
                    Console.WriteLine("5. Back to main menu");
                    Console.Write("Enter your choice: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            CreateOrder();
                            break;
                        case "2":
                            DeleteOrder();
                            break;
                        case "3":
                            UpdateOrder();
                            break;
                        case "4":
                            PrintOrders();
                            break;
                        case "5":
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }

            static void CreateOrder()
            {
                Console.Write("Enter order number: ");
                int orderNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter customer name: ");
                string customerName = Console.ReadLine();

                // Find customer
                Customer customer = customers.Find(c => c.Name == customerName);
                if (customer == null)
                {
                    Console.WriteLine("Customer was not found.");
                    return;
                }

                List<Pizza> orderedPizzas = new List<Pizza>();
                while (true)
                {
                    Console.Write("Enter pizza number to add to order ( enter 0 to finish): ");
                    int pizzaNumber = int.Parse(Console.ReadLine());
                    if (pizzaNumber == 0)
                        break;

                    Pizza pizza = pizzas.Find(p => p.PizzaNumber == pizzaNumber);
                    if (pizza != null)
                    {
                        orderedPizzas.Add(pizza);
                    }
                    else
                    {
                        Console.WriteLine("Pizza ¨was not found.");
                    }
                }

                orders.Add(new Order(orderNumber, customer, orderedPizzas));
                Console.WriteLine("Order was created successfully");
            }

            static void DeleteOrder()
            {
                Console.Write("Enter order number to delete: ");
                int orderNumber = int.Parse(Console.ReadLine());

                Order order = orders.Find(o => o.OrderNumber == orderNumber);
                if (order != null)
                {
                    orders.Remove(order);
                    Console.WriteLine("Order deleted successfully");
                }
                else
                {
                    Console.WriteLine("Order was not found.");
                }
            }

            static void UpdateOrder()
            {
                Console.Write("Enter order number to update: ");
                int orderNumber = int.Parse(Console.ReadLine());

                Order order = orders.Find(o => o.OrderNumber == orderNumber);
                if (order != null)
                {
                    Console.Write("Enter new customer name: ");
                    string newCustomerName = Console.ReadLine();

                    // Find customer
                    Customer newCustomer = customers.Find(c => c.Name == newCustomerName);
                    if (newCustomer != null)
                    {
                        order.Customer = newCustomer;

                        List<Pizza> newOrderedPizzas = new List<Pizza>();
                        while (true)
                        {
                            Console.Write("Enter new pizza number to add to order (enter 0 to finish): ");
                            int pizzaNumber = int.Parse(Console.ReadLine());
                            if (pizzaNumber == 0)
                                break;

                            Pizza pizza = pizzas.Find(p => p.PizzaNumber == pizzaNumber);
                            if (pizza != null)
                            {
                                newOrderedPizzas.Add(pizza);
                            }
                            else
                            {
                                Console.WriteLine("Pizza was not found.");
                            }
                        }

                        order.Pizzas = newOrderedPizzas;

                        Console.WriteLine("Order updated successfully");
                    }
                    else
                    {
                        Console.WriteLine("Customer was not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Order was not found.");
                }
            }
        }
    }
}
    
