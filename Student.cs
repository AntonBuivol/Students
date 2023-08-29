using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        public string Name { get; }
        public int age { get; }
        private readonly string _city;
        public string status;

        public Student(string name, int age, string city)
        {
            Name = name;
            Age = age;
            _city = city;
        }
        public int Age
        {
            get { return age; }
            set
            {
                Age = value;
                if (age < 18) status = "alaealine";
                else status = "täiskasvaanud";
            }
            
        }

        public int Birth
        {
            get { return age; }
        }
        

        public string Status
        {
            get { return status; }
        }
        public string GetCity()
        {
            return _city;
        }

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(GetCity());
        }
    }
}
