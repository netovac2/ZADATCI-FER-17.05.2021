using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK5
{
    class Teacher:Person
    {
        public string Subject { get; set; }
        public double TeacherGrade { get; set; }
        public Teacher(int ID, string Name, string subject, double teacherGrade)
            : base(ID, Name)
        {
            Subject = subject;
            TeacherGrade = teacherGrade;
        }

        public override string ToString()
        {
            return "TEACHER   " + "ID: " + ID + ", " + "Name: " + Name + ", " + "Subject: " + Subject + ", " + "Techer Grade" + TeacherGrade;
        }

        public override int GetGrade()
        {
            int teacherGrade1 = (int)TeacherGrade;
            return teacherGrade1;
        }

        public override bool IsOutstanding()
        {
            double teacherGrade2 = TeacherGrade;

            if (teacherGrade2 > 4.5)
            {
                return true;
            }

            else
                return false;

        }
    }
}
