﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    class Person : IDeserializationCallback
    {
        private string name { get; set; }
        private int birthYear { get; set; }
        [NonSerialized]
        private int age;

        public void OnDeserialization(object sender)
        {
        }

        public Person()
        {

        }

        public Person(String name, int birthYear, int age)
        {
            this.name = name;
            this.birthYear = birthYear;
            this.age = age;
        }

        public override string ToString()
        {
            return "Name: " + name + " Age: " + age;
        }

    }
}
