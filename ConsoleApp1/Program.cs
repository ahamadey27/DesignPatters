using System;
using System.Runtime.CompilerServices;


//---Encapsulation--- 
// using ConsoleApp1.src.OopPrinciples.Encapsulation;
// BankAccount bankAccount = new BankAccount(100); //create an instance of BankAccount
// Console.WriteLine(bankAccount.GetBalance());
// bankAccount.Deposit(50);
// Console.WriteLine(bankAccount.GetBalance());
// bankAccount.Withdraw(100);
// Console.WriteLine(bankAccount.GetBalance());
/*




//---Abstraction---
using ConsoleApp1.src.OopPrinciples.Abstraction;
//Create an instance of of EmailService to call method
EmailService emailService = new EmailService();
emailService.SendEmail();*/



//---Inheritance---
/*using ConsoleApp1.src.OopPrinciples.Inheritance;

var car = new Car();

//Shared
car.Brand = "Ford";
car.Start();
car.Stop();*/




//---Polymorphism---
/*using ConsoleApp1.src.OopPrinciples.Polymorphism;

List<Vehicle> vehicles = new List<Vehicle>
{
    new Car {Brand = "Toyota", Model = "Camry", Year = 2020, NumberOfDoors = 4},
    new Car {Brand = "Harley", Model = "Sportser", Year = 2022,}
};

foreach (var vehicle in vehicles)
{
    Console.WriteLine($"Inspecting {vehicle.Brand} {vehicle.Model} ({vehicle.GetType().Name})");
    vehicle.Start();
    vehicle.Stop();
    Console.WriteLine();
}*/




//---Coupling---
using ConsoleApp1.src.OopPrinciples.Coupling;
var order = new Order(new EmailSender());
order.PlaceOrder();


