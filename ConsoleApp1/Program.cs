﻿using System;

namespace practica1
{

  struct Person
  {
    public enum Genders : int { Male, Female };  //объявление в структуре Person новое перечислимое. Даю ему имя Genders и указываю два
                                                 // возможных значения: Male и Female.
    public string firstName;
    public string lastName;
    public int age;
    public Genders gender;
    
    public Person(string _firstName, string _lastName, int _age, Genders _gender)
    {
      firstName = _firstName;
      lastName = _lastName; 
      age = _age;
      gender = _gender;
      
    }
    public override string ToString()
    {
      return firstName + " " + lastName +"("+  gender + ")" + ", age " + age;
    }
  }


  class Program

  {
    static void Main(string[] agrs)
    {
      Person p = new Person("Tony", "Allen", 32, Person.Genders.Male);
      Console.WriteLine(p.ToString());
    }
  }
}
