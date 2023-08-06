using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMinisters
{
    class PrimeMinister
    {
        private string firstName;
        private string lastName;
        private string term;
        private string party;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Term
        {
            get
            {
                return term;
            }
            set
            {
                term = value;
            }
        }

        public string Party
        {
            get
            {
                return party;
            }
            set
            {
                party = value;
            }
        }

    }
}
