using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Person : IEnumerable
    {
        public Person()
        {

        }
        public Person(string name, string address, int age, int mobile, Type type)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.mobile = mobile;
            this.type = type;
        }
        public string name { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public int mobile { get; set; }
        public enum Type
        {
            Home, Workplace, Mobile
        }
        public Type type { get; set; }

        public override string ToString()
        {
            return (String.Format("name: {0}, address: {1}, age: {2}, mobile: {3}", name , address, age, mobile));
        }

        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
