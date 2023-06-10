using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person : INodeElement , IAcceptVisits
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public int PersonId { get; set; }

        public Person(string name, int age, int personId)
        {
            this.Name = name;
            this.Age = age;
            this.PersonId = personId;
        }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public int GetValue()
        {
            return this.Age;
        }
        public int GetNodeElementId()
        {
            return this.PersonId;
        }

        public string GetNodeElementName()
        {
            return this.Name;
        }


    }
}