using System;
using System.Collections;
using System.Collections.Generic;

namespace Student
{
    class Program
    {
        public class Student : IComparable<Student>
            {
                public string name { get; set; }
                public int sID { get; set; }

                public Student(string Name, int SID)
            {
                name = Name;
                sID = SID;
            }

            public Student()
            {
            }

            public int CompareTo(Student other)
            {
                if (this.sID > other.sID)
                    return -1;
                if (this.sID < other.sID)
                    return 1;
                return 0;
            }


        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){
                    name = "Huynh Nguyen Thien Phuc", sID = 4
                },
                new Student(){
                    name = "Huynh Vo Phu", sID = 3
                },
                new Student(){
                    name = "Babe", sID = 1
                },
            };


            foreach (Student s in students)
            {
                Console.WriteLine($"Name: {s.name} - ID: {s.sID}");
            }

//            students.Sort((IComparer<Student>)students);

            foreach (Student s in students)
            {
                Console.WriteLine($"Name: {s.name} - ID: {s.sID}");
            }
        }
    }
}
