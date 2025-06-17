using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.OopPrinciples.Coupling
{
    //Coupling refers to the degree of dependency between different classes or modules within a system.
    //Tight coupled is claases are tighly connected
    //Loose coupled means classes can have more flexibilty for modification 
    public class Order
    {
        private readonly INotificationService notificationService;
        public Order(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }
        public void PlaceOrder()
        {
            notificationService.SendNotification("Order placed successfully");
        }

    }
}