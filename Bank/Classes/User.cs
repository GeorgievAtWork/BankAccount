using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Classes
{
    public class User
    {
        //Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardGUID { get; set; }
        public Card DebitCard { get; set; }

        //Constructors
        public User() { }
        public User(string firstName, string lastName,string cardGUID)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CardGUID = cardGUID;
        }

    }
}
