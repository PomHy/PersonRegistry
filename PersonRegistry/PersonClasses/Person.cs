using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegistry
{
    public abstract class Person : IComparable<Person>
    {
        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PersonTitle { get; set; }
        public string FullName => GetName();

        public int CompareTo(Person other)
        {
            return Firstname.CompareTo(other.Firstname);
        }

        public abstract string GetName();
        public abstract string GetStatus();
        
        public static Child operator +(Person firstname, Person lastname) =>
            new Child(firstname.Firstname, lastname.Lastname);

    }
}
