using GameProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concreate
{
    public class EdevletManager : IEdevletServices
    {
        public bool Control(IPerson person)
        {
            if(person.TcNo == "" || person.FirstName == "" || person.LastName == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
