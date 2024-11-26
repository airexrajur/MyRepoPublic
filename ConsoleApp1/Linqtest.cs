using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Linqtest
    {
        public List<Student> students;
        public Linqtest()
        {
            students = new List<Student>()

            {
                new Student { Id = 1, Name = "John", Age = 18, Grade = "A" },
    new Student { Id = 2, Name = "Jane", Age = 20, Grade = "B" },
    new Student { Id = 3, Name = "Sam", Age = 19, Grade = "A" },
    new Student { Id = 4, Name = "Sue", Age = 21, Grade = "C" },
    new Student { Id = 5, Name = "Bill", Age = 22, Grade = "B" },
    new Student { Id = 6, Name = "Michael", Age = 23, Grade = "C" },
    new Student { Id = 7, Name = "Juli" , Age = 24, Grade = "A" },
    new Student { Id = 8, Name = "Asha" , Age = 25, Grade = "B" }

    };
        }

        public void getALLstudents()
        {
            Console.WriteLine("Allstudents"); 
        var allStudents = from s in students
                              select s;

            foreach (var student in allStudents)
            {
                Console.WriteLine($" {student.Id} - {student.Name} -  {student.Age} - {student.Grade} ");
            }
        }

        public void getStudentwithGrade()
        {
            Console.WriteLine("Student with Grade A");
            var gradeAStudents = from s in students
                                 where s.Grade == "A"
                                 select s;
            var grantedStudents = from s in students
                                  where s.Grade == "A"
                                  group s by s.Age into aa
                                  select new { age = aa.Key, Stud = aa };
                                 //select aa;

            foreach (var student in gradeAStudents)
            {
                Console.WriteLine(student.Name);
}
            Console.WriteLine("---Age--");

            foreach (var student in grantedStudents)
            {
                Console.WriteLine(student);
            }
        }
        public void groupby()
        {
            Console.WriteLine($"{students.Count()} students group by Grade ");
            var studentsByGrade = from s in students
                                  group s by s.Grade into g
                                  select new { Grade = g.Key, Students = g };

            foreach (var group in studentsByGrade)
            {
                Console.WriteLine($"Grade: {group.Grade}");
                foreach (var student in group.Students)
                {
                    Console.WriteLine(student.Name);
                }
            }

        }

        public void oldeststud()
        {
            var oldestStudent = (from s in students
                                 orderby s.Age descending
                                 select s).FirstOrDefault();

            Console.WriteLine($"Oldest student: {oldestStudent.Name}, Age: {oldestStudent.Age}");

        }

        public void pagination() 
        {
            int pagesize = 3;
            int pageno = 2;//change this get diferent page size
            var paginationStudent = students
                .Skip((pageno - 1) * pagesize)
                .Take(pagesize)
                .ToList();
            foreach(var student in paginationStudent)
            { 
                Console.WriteLine($"{student.Name} pageno: {pageno} pagesize { pagesize}" ); 
            }

        }

    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
    }



}
