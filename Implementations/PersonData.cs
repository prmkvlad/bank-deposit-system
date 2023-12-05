using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Implementations
{
    internal class PersonData
    {
        public string name { get; private set; }
        public string surname { get; private set; }
        public string patronymic { get; private set; }
        public string gender { get; private set; }
        public DateTime birthDate { get; private set; }
        public string address { get; private set; }
        public string phone { get; private set; }
        public string ID { get; private set; }
        public string occupation { get; private set; }

        public PersonData(string firstName, string surname, string patronymic, string gender, DateTime birthDate, string address, string phone, string ID, string occupation)
        {
            this.name = firstName;
            this.surname = surname;
            this.patronymic = patronymic;
            this.gender = gender;
            this.birthDate = birthDate; 
            this.address = address;
            this.phone = phone;
            this.ID = ID;
            this.occupation = occupation;
        }
    }
}
