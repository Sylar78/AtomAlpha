using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AtomAlpha.Model
{
    internal class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }

        public Person(string _lastname, string _firstname, string _age, string _gender)
        {
            LastName = _lastname;
            FirstName = _firstname;
            Age = _age;
            Gender = _gender;
        }
    }
}