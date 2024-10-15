using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_w4_firstClass
{
    public class Person //sınıf oluşturduk
    {
        //Fields
        private string name;  
        private string surname;
        private DateTime birthDay;

        //encapsulation
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public DateTime BirthDay
        {
            get { return birthDay; }
            set { birthDay = value; }
        }


        public void PersonInfo() //personel bilgi için method
        {
            Console.WriteLine($"Adı: {name}\r\nSoyadı: {surname}\r\nDoğum Tarihi: {birthDay.ToString("dd.MM.yyyy")}");
        }
    }
}
