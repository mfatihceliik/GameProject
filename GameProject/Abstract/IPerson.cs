using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Interfaces
{
    public interface IPerson
    {
        public int Id { get; set; }
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Wallet { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
