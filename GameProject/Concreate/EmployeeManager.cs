using GameProject.Abstract;
using GameProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concreate
{
    public class EmployeeManager :EdevletManager, IPersonDal
    {
        public void Add(IPerson person, List<ILoggerService> loggerService)
        {
            if(Control(person) == true)
            {
                Console.WriteLine("Çalışan Eklendi : " + person.FirstName + " " + person.LastName.ToUpper() + ", Hoş Geldiniz.");
                foreach (var log in loggerService)
                {
                    log.Log();
                }
            }
            else
            {
                Console.WriteLine("Böyle Bir Kullanıcı yok !");
            }
        }

        public void Delete(IPerson person, List<ILoggerService> loggerService)
        {
            Console.WriteLine("Çalışan Silindi : " + person.FirstName + " " + person.LastName.ToUpper());
            foreach (var log in loggerService)
            {
                log.Log();
            }
        }

        public void Update(IPerson person, List<ILoggerService> loggerService)
        {
            Console.WriteLine("Çalışan Güncellendi : " + person.FirstName + " " + person.LastName.ToUpper());
            foreach (var log in loggerService)
            {
                log.Log();
            }
        }
    }
}
