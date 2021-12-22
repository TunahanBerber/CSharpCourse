using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polimorfizm çok biçimlilik
            //InterfacesIntro();
            //Demo2();
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OraclerCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }




            Console.ReadLine();
        }

    private static void Demo2()
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new SqlServerCustomerDal());
    }

    private static void InterfacesIntro()
    {
        PersonManager menager = new PersonManager();
        Customer customer = new Customer

        {
            Id = 1,
            FirstName = "Tunahan",
            LastName = "Berber",
            Address = "Ankara",
        };

        Student student = new Student
        {
            Id = 1,
            FirstName = "Büşra",
            LastName = "Boztepe",
            Departmant = "Computer Sciences"
        };
        Worker worker = new Worker
        {
            Id = 1,
            FirstName = "Sergen",
            LastName = "Öğreş",
            Departmant = "Security"
        };

        menager.Add(customer);
        menager.Add(student);
        menager.Add(worker);
    }
}

}

interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Address { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}

