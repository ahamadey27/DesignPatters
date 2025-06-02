using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.OopPrinciples.Abstraction
{
    public class EmailService
    {
        //Abstraction
        //Reduces complexity by hiding unnecessary detail

        public void SendEmail()
        {
            Connect();
            Authenticate();
            Console.WriteLine("Sending email...");
            Disconnect();
        }
        //All methods are private as there's no need for users to see complexity and make less decisions from methods

        private void Connect()
        {
            Console.WriteLine("Conecting to email service...");
        }

        private void Authenticate()
        {
            Console.WriteLine("Authenticating...");
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnecting from the email server...");
        }
    }
}