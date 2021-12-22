using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName = "Tunahan"},
                new Student{FirstName = "Onur"},
                new Person{FirstName = "Büşra"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();

        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Person2
        {
            
        }

        class Customer : Person   //Person2 aynı anda gelemez bir kişinin 2 babası olamaz gibi bir şey IPerson yazılabilir classların tek başına anlamı var ama inheritance yok
        {
            public string City { get; set; }
        }

        class Student : Person
        {
            public string Departmant { get; set; }
        }
    }
}
//Eğer seneryo bu projede gibi ise interfacelerden devam etmek daha mantıklı
//inheritance kullanmamız gereken durumlar abstract classlar daha uygun olur
//eğer inheritance zorunluluk değilse interfacelerden yürümek mantıklıdır

