using System;

namespace Practica1
{
    struct Person
    {
        /// <summary>
        /// поля
        /// </summary>
        public string firstName;
        public string lastName;
        public int age;

        /// <summary>
        /// конструктор
        /// </summary>
       
        public Person(string _fistName, string _lastName, int _age)
        {
            firstName = _fistName;
            lastName = _lastName;
            age = _age;
        }

        /// <summary>
        /// переопределение метода ToString
        /// </summary>
        

        public override string ToString()
        {
            return firstName + " " + lastName + ", age " + age; 
        }


        static void Main(string[] args)
        {
            Person p = new Person("Tony", "Allen", 32);
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
