using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workers
{
    internal class Employee
    { 
        public int Code { get; set; }
        public int Id { get; set; }
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName;} }
        public int Age { get {return DateTime.Now.Year - BirthDay.Year; } }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public byte NumberHome { get; set; }
        public bool IsMale { get; set; }
        public string Status { get; set; }

        public Employee(int code, int id, string firstName, string lastName, DateTime birthDay, string phone, string mobilePhone, string street,  byte homeNumber, string city ,bool isMale, string status)
        {
            this.Code = code;
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDay = birthDay;
            this.Phone = phone;
            this.MobilePhone = mobilePhone;
            this.Street = street;
            this.City = city;
            this.NumberHome = homeNumber;
            this.IsMale = isMale;
            this.Status = status;
        }
    }
}
