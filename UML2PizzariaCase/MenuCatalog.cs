using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UML2PizzariaCase
{
    internal class MenuCatalog
    {
        private List<Pizza> pizzas;

        public class Pizza
        {
            int PizzaNumber { get; set; }
            string Name { get; set; }
            string Toppings { get; set; }
            int Price { get; set; }
            public Pizza(int pizzanumber, string name, string toppings, int price)
            {
                PizzaNumber = pizzanumber;
                Name = name;
                Toppings = toppings;
                Price = price;

            }
        }
        public MenuCatalog()
        {
            List<Pizza> pizzas = new List<Pizza>
            {
                new Pizza(1, "Margherita", "Cheese & sauce", 69),
                new Pizza(2, "Vesuvio", "Tomato, cheese & ham", 75),
                new Pizza(3, "Capriccsia", "Tomato, cheese, ham & mushroom", 80),
                new Pizza(4, "Calzone", "Baked pizza tomato, cheese, ham & mushroom", 80),
                new Pizza(5, "Quattro Stagioni", "Tomato, cheese, ham, mushroom, shrimp & peppers", 85),
                new Pizza(6, "Marinara", "Tomato, cheese, shrimp, musssels & garlic", 85),
                new Pizza(7, "Vegetarian", "Tomato, cheese & vegetables", 80),
                new Pizza(8, "Italiana", "Tomato, cheese, onion & meat sauce", 75),
                new Pizza(9, "Gorgonzola", "Tomato, gorgonzola, onion, & mushroom", 85),
                new Pizza(10, "Contadina", "Tomato, cheese, mushroom & olivers", 75),
                new Pizza(11, "Naples", "Tomato, Cheese, Anchovies & olivers", 79),
                new Pizza(12, "Vichinga", "Tomato, cheese, ham, mushrooms, peppers, garlic & chili(strong)", 80),
                new Pizza(13, "Calzone special", "(Not baked) tomato, cheese, shrimp, ham & meat sauce", 80),
                new Pizza(14, "Esotica", "Tomato, cheese, ham, shrimp & pineapple", 80),
                new Pizza(15, "Tonno", "Tomato, cheese, tuna & shrimp", 85),
                new Pizza(16, "Sardegna", "Tomato, cheese, cocktail sausages, bacon, onions & eggs", 80),
                new Pizza(17, "Romana", "Tomato, cheese, ham, bacon & onion", 78),
                new Pizza(18, "Sole", "Tomato, cheese, ham, bacon & eggs", 78),
                new Pizza(19, "Big mamma", "Tomato, gorgonzola, shrimp, asparagus & parma ham", 90),


                /* Name = name;
                Number = number;
                Price = price;
                Toppings = toppings;
                */
            };


        }
    }
}
    
