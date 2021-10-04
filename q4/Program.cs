using System;
using System.Collections.Generic;

namespace q4
{
    
    class Program
    {
        static void Main(string[] args)
        {
            /*SudentRecord s1 = new SudentRecord("","",'');
            SudentRecord s2 = new SudentRecord("", "", '');
            SudentRecord s3 = new SudentRecord("", "", '');
            List <SudentRecord> numbers = new List<SudentRecord>() {  };*/

            StudentRecord s1 = new StudentRecord("John", new List<Courses>() { new Courses("IERG3080", 'B'), new Courses("IERG3300", 'A')});
            StudentRecord s2 = new StudentRecord("Mary", new List<Courses>() { new Courses("IERG3080", 'A'), new Courses("IERG3300", 'A'), new Courses("GEEC1000", 'B') });
            List<StudentRecord> l = new List<StudentRecord>() { s1, s2 };
            l.Sort();
            foreach (StudentRecord c in l)
            {
                Console.WriteLine(c.Cgpa);
            }


        }
    }
    public class StudentRecord : IComparable<StudentRecord>
    {
        private string name;
        List<Courses> courses ;
        private double cgpa;
        public StudentRecord(string name, List<Courses> courses)
        {
            this.name = name;
            this.courses = courses;
            cgpa = CGPA(courses);
        }

        public string Name { get => name; set => name = value; }
        public IEnumerable<Courses> Courses
        {
            get
            {
                return courses;
            }
        }

        public double Cgpa { get => cgpa; set => cgpa = value; }

        public void AddCourse(Courses course)
        {
            courses.Add(course);
        }



        public double CalculateGPA(char grade)
        {
            if (grade == 'A')
            {
                return 4.0;
            }
            else if (grade == 'B')
            {
                return 3.3;

            }
            else if (grade == 'C')
            {
                return 2.7;
            }
            else if (grade == 'D')
            {
                return 0.0;
            }
            else return -1;
        }
        public double CGPA(List<Courses> courses)
        {
            double cgpa = 0;
            foreach (Courses c in courses)
            {
                cgpa += CalculateGPA(c.Grade);
            }
            return cgpa/ courses.Count;
        }
        public int CompareTo(StudentRecord other)
        {

            if (other==null)
                return 1;  
           else
            {
                return -(cgpa.CompareTo(other.Cgpa));
            }

        }
        public override string ToString()
        {
            string s = "";
            foreach(Courses c in courses)
            {
                s += (c.Coursesname + " " + c.Grade+" ");
            }
            return s;
        }

    }
    public class Courses
    {
        private string coursesname;
        private char grade;

        public Courses(string coursesname, char grade)
        {
            this.coursesname = coursesname;
            this.grade = grade;
        }

        public string Coursesname { get => coursesname; set => coursesname = value; }
        public char Grade { get => grade; set => grade = value; }
    }

}
