using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK5
{
    class Student : Person
    {
        public int AcademicYear { get; set; }
        public int[] PoljeOcjena { get; set; }

        public Student(int ID, string Name, short academicYear, int[] poljeOcjena)
            : base(ID, Name)
        {
            AcademicYear = academicYear;
            PoljeOcjena = poljeOcjena;
        }



        public override string ToString()
        {
            return "STUDENT   " + "ID: " + ID + ", " + "Name: " + Name + ", " + "Academic Year: " + AcademicYear + ", " + "Polje Ocjena: " + PoljeOcjena;
        }

        public override int GetGrade()
        {
            int ocjene = PoljeOcjena[0] + PoljeOcjena[1] + PoljeOcjena[2] + PoljeOcjena[3] + PoljeOcjena[4];
            return ocjene;
        }

        public override bool IsOutstanding()
        {
            int ocjene1 = (PoljeOcjena[0] + PoljeOcjena[1] + PoljeOcjena[2] + PoljeOcjena[3] + PoljeOcjena[4]) / 5;

            if (ocjene1 > 4.5)
            {
                return true;
            }

            else
                return false;
        }
    }
}
