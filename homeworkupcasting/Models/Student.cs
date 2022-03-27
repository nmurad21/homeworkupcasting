using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkupcasting.Models
{
    class Student
    {
        private static int count;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Point { get; set; }
        public Student(string name, string surname, int age, int point)
        {
            Id = ++count;
            Name = name;
            Surname = surname;
            Age = age;
            Point = point;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{Id} {Name} {Surname} {Age} {Point} ");
        }
        public static bool operator >(Student student, Student student1)
        {
            return student.Point > student1.Point;
        }
        public static bool operator <(Student student, Student student1)
        {
            return student.Point < student1.Point;
        }

    }
}
