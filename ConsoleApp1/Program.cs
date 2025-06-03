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
using ConsoleApp1.src.OopPrinciples.Inheritance;

var car = new Car();

//Shared
car.Brand = "Ford";
car.Start();
car.Stop();
