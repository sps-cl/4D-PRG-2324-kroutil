﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.model
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }
    }

}
