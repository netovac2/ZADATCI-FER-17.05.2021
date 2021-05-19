using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK5
{
   abstract class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Person(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return "PERSON   " + "ID: " + ID + ", " + "Name: " + Name;
        }

        public abstract int GetGrade();

        public abstract bool IsOutstanding();
    }
}
