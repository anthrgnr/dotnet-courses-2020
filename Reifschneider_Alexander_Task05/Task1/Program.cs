using System;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            User user = new User("Alexander", "Valeryevich", "Reifschneider", new DateTime(1999, 11, 1));
            Console.WriteLine("Userdata:");
            Console.WriteLine("First name: " + user.FirstName);
            Console.WriteLine("Middle name: " + user.MiddleName);
            Console.WriteLine("Last name: " + user.LastName);
            Console.WriteLine("Date of Birth: " + user.DateofBirth.ToShortDateString());
            Console.WriteLine("Age: " + user.Age);
        }
    }

    public class User
    {
        public DateTime DateofBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }

        public User(string firstName, string middleName, string lastName, DateTime dateofBirth)
        {
            DateofBirth = dateofBirth;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            if (DateTime.Now.Month > dateofBirth.Month)
            {
                Age = DateTime.Now.Year - dateofBirth.Year;
            }
            else if (DateTime.Now.Month == dateofBirth.Month)
            { 
                if (DateTime.Now.Day >= dateofBirth.Day)
                    Age = DateTime.Now.Year - dateofBirth.Year;
            }
            else
            {
                Age = DateTime.Now.Year - dateofBirth.Year - 1;
            }
        }
    }
}