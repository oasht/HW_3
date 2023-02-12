
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Test
{

    class Student
    {
        string lname;
        string fname;
        int age;
        double avg;
        static string Group;
        static Student()
        {
            Group = "PV221";

        }
        public Student() : this("not lname", "not fname", 0, 0) { }

        public Student(string lname, string fname, int age, double avg)
        {
            this.lname = lname;
            this.fname = fname;
            this.age = age;
            this.avg = avg;
            

        }
        public void Show()
        {
            WriteLine($"{lname} {fname} {age} {avg} {Group}");
        }

        public void SetFName()
        {
            WriteLine($"enter name");
            fname = ReadLine();
        }
        public string GetFName()
        {
            return fname;
        }
        public override string ToString()
        {

            return $"{lname} {fname} {age} {avg} {Group}";
        }


        static void Age_mark(ref Student st, ref bool b)
        {
            if (st.age >= 18)
            {
                b = true;
            }
            else
            {
                b = false;
            }

            if (b)
                WriteLine("Student is adult");
            else WriteLine("Student is under age");

        }
        static double Randomizer(out Student st, out Random r)
        {
            r = new Random();
            st = new Student();
            st.avg = r.Next(12)+r.NextDouble();
            return Math.Round(st.avg, 2);
        }
        internal class Program
        {




            static void Main(string[] args)
            {
                bool b = true;
                Student s;
                double a;
                Random r;
                Student s1 = new Student("LN1", "FN1", 15,Randomizer(out s, out r));
                Student s2 = new Student("LN2", "FN2", 20, Randomizer(out s, out r));
                Student s3 = new Student("LN3", "FN3", 32, Randomizer(out s, out r));

               s1.Show(); Age_mark(ref s1, ref b);WriteLine();
                s2.Show(); Age_mark(ref s2, ref b); WriteLine();
                s3.Show(); Age_mark(ref s3, ref b); WriteLine();
                
                
               

            }
        }
    }
}

















