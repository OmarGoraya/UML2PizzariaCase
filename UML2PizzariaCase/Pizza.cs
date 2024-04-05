using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2PizzariaCase
{
    public class Pizza
    {
        int PizzaNumber { get; set; }
        string Name { get; set; }
        string Toppings { get; set; }
        int Price { get; set; }
        public Pizza (int pizzanumber, string name, string toppings, int price)
        {
            PizzaNumber = pizzanumber;
            Name = name;
            Toppings = toppings;
            Price = price;
            
        }
    }
}
