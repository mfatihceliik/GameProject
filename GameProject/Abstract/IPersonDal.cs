using GameProject.Concreate;
using GameProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IPersonDal
    {
        void Add(IPerson person, List<ILoggerService> loggerService);
        void Update(IPerson person, List<ILoggerService> loggerService);
        void Delete(IPerson person, List<ILoggerService> loggerService);
    }
}
