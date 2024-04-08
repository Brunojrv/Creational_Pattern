using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Criacionais.Prototype
{
    public class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private string NumberPerson { get; set; }

        public Person()
        {
            NumberPerson = new Random().Next().ToString();
        }
        public object Clone()
        {
            return new Person
            {
                Name = Name,
                Age = Age,
                NumberPerson = NumberPerson
            };
        }
    }
}
