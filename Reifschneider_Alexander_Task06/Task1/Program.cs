using System;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            User user = new User("Alexander", "Valeryevich", "Reifschneider", new DateTime(1999, 11, 1));
            Employee emp = new Employee(user, 4, "Student");
            Console.WriteLine("Employee data:");
            Console.WriteLine("First name: " + emp.FirstName);
            Console.WriteLine("Middle name: " + emp.MiddleName);
            Console.WriteLine("Last name: " + emp.LastName);
            Console.WriteLine("Date of Birth: " + emp.DateofBirth.ToShortDateString());
            Console.WriteLine("Age: " + emp.Age);
            Console.WriteLine("Experience: " + emp.Experience);
            Console.WriteLine("Post: " + emp.Post);
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

    public class Employee : User
    {
        private int experience;

        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                if ((value < 0) || (value > 110))
                    throw new Exception("That's impossible");
                else
                    experience = value;
            }
        }

        public string Post { get; set; }

        public Employee(string firstName, string middleName, string lastName, DateTime dateofBirth, int experience, string post) : base(firstName, middleName, lastName, dateofBirth)
        {
            Experience = experience;
            Post = post;
        }

        public Employee(User user, int experience, string post) : base(user.FirstName, user.MiddleName, user.LastName, user.DateofBirth)
        {
            Experience = experience;
            Post = post;
        }
    }
}