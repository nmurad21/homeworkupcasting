using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkupcasting.Models
{
    class Group
    {
        private static int _count = 100;
        public int No { get; }
        private Student[] students = new Student[0];
        public Group()
        {
            _count++;
            No = _count;
        }
        public void Addstudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
        public Student[] GetAllStudents()
        {
            return students;
        }
        public void Sort()
        {
            Array.Sort(students);

        }
    }
}
