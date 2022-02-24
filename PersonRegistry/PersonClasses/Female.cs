using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegistry
{
    public class Female : Person
    {
        
        public Female(string firstname, string lastname)
            : base(firstname, lastname)
        {
            PersonTitle = "Miss.\t";
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
