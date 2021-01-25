using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Interfaces;

namespace GameProject.Concreate
{
    class SqlLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sql Server' a Loglama yapıldı.");
        }
    }
}
