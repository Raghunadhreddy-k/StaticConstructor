using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{ 
    class student
    {
        int sid;
        string sname;
        static string college;

        public student(int sid, string sname)
        {
            this.sid = sid;
            this.sname = sname;
        }
        static student()
        {
            college = "JNTU";
        }
        public void studentDisplay()
        {
            Console.WriteLine("student id is " + sid);
            Console.WriteLine("student name is " + sname);
        }
        public static void collegeDsiplay()
        {
            Console.WriteLine("college name is "+college);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student obj = new student(1, "Raghu");
            obj.studentDisplay();
            student s = new student(2,"Vijay");
            s.studentDisplay();
            student sobj = new student(3, "Nikhil");
            sobj.studentDisplay();
            student.collegeDsiplay();
        }
    }
}