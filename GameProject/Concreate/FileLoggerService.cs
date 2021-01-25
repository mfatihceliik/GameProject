using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Interfaces;

namespace GameProject.Concreate
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosya' ya Loglama yapıldı.");
        }
    }
}
