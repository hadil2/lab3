using Microsoft.AspNetCore.Mvc;

namespace Lab3.Models
{
    public class Person
    {
        [BindProperty(Name = "first")]
        public string FirstName
        {
            get;
            set;
        }


        public string LastName
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }


        public string Email
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }
    }
}
