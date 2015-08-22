using System;
using System.Collections.Generic;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SimpleDemo
{
    [HubName("simpleDashboard")]
    public class SimpleHub : Hub
    {
        //Declare and instantiate a list for keeping track of new orders.
        static readonly IList<Order> _orders = new List<Order>();
 
        public void AddOrder(Order order)
        {
            //Update incoming order with an orderdate.
            order.OrderDate = DateTime.Now.ToString();
            //Add the order to our fake orderlist.
            _orders.Add(order);
            //Define the callback method which the client need to create to be able to listen for broadcasts.
            Clients.All.OnAddOrder(_orders);
        }
    }
    public class Order
    {
        public string OrderDate { get; set; }
        public string ProductName { get; set; }
        public string CustomerName { get; set; }
        public int Quantity { get; set; }
    }
}