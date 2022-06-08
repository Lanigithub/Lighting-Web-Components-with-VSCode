using System;
using IntroLibrary;

namespace IntroUI {
    class Program {
        static void Main(string[] args) {
            PersonModel p = new PersonModel() {
                FirstName = "Jenny",
                LastName = "Johnson"
            };
            Console.WriteLine($"{p.FirstName} {p.LastName} is my name");

            Console.WriteLine("Hello, World!");
            Console.WriteLine("This is a test");
        }
    }   
}
;