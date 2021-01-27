using GameDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{


    public class Player : IEntity
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNumber { get; set; }
        public string MailAdress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string PlayerName { get; set; }
        public string PlayerPassword { get; set; }
        public double Balance { get; set; }
        public double Bonus { get; set; }
    }
}

