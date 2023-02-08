using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace HasARelationship
{
     class Address
     {
        public string street, city, state, zipcode;
        public Address(string street, string city, string state, string zipcode)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
        }
     }
}
 class Employee
 {
    public int empid;
    public string name;
    public Address address;
    public Employee(int id, string name, Address address)
    {
        this.empid = id;
        this.name = name;
        this.address = address;

    }
               
    public void GetEmplInfo()
    {
        Console.WriteLine($"Empl Id={empid}\n Name={name}\n State={address.state}\n Zipcode={address.zipcode}");
    }
 }


internal class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("Nehru street", "Tirupur", "TamilNadu", "641001");
        Employee employee = new Employee(101, "Geetha", address);
        employee.GetEmplInfo();
    }

}
    
