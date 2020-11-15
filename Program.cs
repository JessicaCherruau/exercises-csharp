using System;
using System.Linq;

namespace TestInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new[] { new Person {
            FirstName = "Charlotte",
            Age = 31,
            City = "Paris",
            Email = "charlotte@test.com"
        }, new Person {
            FirstName = "Anna",
            Age = 35,
            City = "Paris",
            Email = "anna@test.com"
        }, new Person {
            FirstName = "Bruno",
            Age = 25,
            City = "Paris",
            Email = "bruno@test.com"
        }};

            // output: "anna@test.com,charlotte@test.com"
            Console.WriteLine(string.Join(',', Person.GetConcernedEmails(persons)));

            var emails = MessyPersonProvider.GetEmails();
            Console.WriteLine(string.Join(',', emails));
        }
    }
}
