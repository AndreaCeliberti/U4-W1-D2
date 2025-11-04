using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace U4_W1_D2
{
    public class Persona 
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public Persona (string name, string lastname, int age)
        {
            Name = name;
            Lastname = lastname; 
            Age = age;  

           
    }
        public string getName() { return Name; }
        public string getLastname() { return Lastname; }
        public int getAge() { return Age; }
        public string getDetails() { return $"Name: {Name}, Lastname: {Lastname}, Age: {Age}"; }
    }
}
