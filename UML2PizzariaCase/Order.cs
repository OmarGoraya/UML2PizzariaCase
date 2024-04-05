using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML2PizzariaCase;

namespace UML2PizzariaCase
{
    internal class Order
    {
        public int OrderNumber { get; set; }
        public Customer Customer { get; set; }
        public List<Pizza> Pizzas { get; set; }

        public Order(int orderNumber, Customer customer, List<Pizza> pizzas)
        {
            OrderNumber = orderNumber;
            Customer = customer;
            Pizzas = pizzas;
        }
    }
}
