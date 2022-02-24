using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegistry
{
    public class Child : Person
    {

        public Child(string firstname, string lastname)
            : base(firstname, lastname)
        {
            PersonTitle = "Child\t";
        }
        public override string GetName()
        {
            return PersonTitle + Firstname + " " + Lastname;
        }
        public override string GetStatus()
        {
            return PersonTitle;
        }

    }
}
