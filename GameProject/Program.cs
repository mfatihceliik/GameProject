using GameProject.Abstract;
using GameProject.Concreate;
using GameProject.Entities;
using GameProject.Interfaces;
using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Logger
            ILoggerService fileLogger = new FileLoggerService();
            ILoggerService sqlLogger = new SqlLoggerService();
            ILoggerService smsLogger = new SmsLoggerService();

            // Loggers add to List
            List<ILoggerService> loggerService = new List<ILoggerService>()
            {
                fileLogger, sqlLogger, smsLogger
            };
            // Create new Customer
            IPerson customer = new Customer()
            {
                Id = 1, TcNo = "1111111111", FirstName = "Muhammed Fatih", LastName = "Çelik",
                UserName = "mfatihceliik", Wallet = 600, RegistrationDate = DateTime.Now, DateOfBirth = new DateTime(1999, 6, 22)
            };
            // Create new Employee
            IPerson employee = new Employee()
            {
                Id = 2, TcNo = "22222222222", FirstName = "Nazım", LastName = "Hikmet",
                Department = "Information Technology", DateOfBirth = new DateTime(1902,1,15)
            };
            // Created Employee 2 for E-Devlet Service Controll
            IPerson employee2 = new Employee()
            {
                Id = 2,
                TcNo = "22222222222",
                FirstName = "",
                LastName = "Hikmet",
                Department = "Information Technology",
                DateOfBirth = new DateTime(1902, 1, 15)
            };

            // Customer Manager
            IPersonDal customerManager = new CustomerManager();
            customerManager.Add(customer, new List<ILoggerService> {sqlLogger});
            Console.WriteLine("************************");
            // Employee Manager
            IPersonDal employeeManager = new EmployeeManager();
            employeeManager.Add(employee, new List<ILoggerService> {sqlLogger});
            Console.WriteLine("************************");

            // Added Games
            Game cyberPunk = new Game() {Id = 1, GameName = "CyberPunk",Price = 200,UnitsInStock = 100};
            Game redDeadRedemption2 = new Game() {Id = 2,GameName = "Red Dead Redemption 2",Price = 150,UnitsInStock = 80};
            Game grandTheftAutoV = new Game() {Id = 3, GameName = "Grand Theft Auto", Price = 80, UnitsInStock = 70};
            Game callOfDutyBlackOpsColdWar  = new Game(){Id = 4,GameName = "Call of Duty: Black Ops Cold War",Price = 400,UnitsInStock = 110};
            Game marvelsSpiderMan  = new Game(){Id = 5,GameName = "Marvel’s Spider-Man", Price = 120,UnitsInStock = 40};
            // Game List
            List<Game> games = new List<Game>() { cyberPunk, redDeadRedemption2, grandTheftAutoV, callOfDutyBlackOpsColdWar, marvelsSpiderMan };

            IGameServices gameServices = new GameManager();
            // Remove the Campaing
            //gameServices.DeletedCampaing(customer, games);
            gameServices.Sell(customer, cyberPunk);
            Console.WriteLine("************************");
            gameServices.Campaing(customer, games);
            Console.WriteLine("************************");
            gameServices.SpecialCampaign(customer, cyberPunk);
            Console.WriteLine("************************");
            gameServices.CampaingnUpdate(customer, games);
            
        }
    }
}
