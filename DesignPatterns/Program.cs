using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Criacionais.Prototype;
namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Person1 = new Person
            {
                Name = "Bruno",
                Age = 25
            };
            var Person2 = Person1.Clone();
        }
    }
}
