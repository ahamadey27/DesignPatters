using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.OopPrinciples.Coupling
{
    public interface INotificationService
    {
        void SendNotification(string message);
    }
}