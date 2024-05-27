using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_GroupProject_ProgrammingII
{
    public class Student : User
    {
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }

        public static Student FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Student student = new Student();
            student.ID = int.Parse(values[0]);
            student.FirstName = values[1];
            student.LastName = values[2];
            student.DateOfBirth = DateTime.Parse(values[3]);
            student.Gender = values[4];
            return student;
        }

        public string ToCsv()
        {
            return $"{ID},{FirstName},{LastName},{DateOfBirth.ToShortDateString()},{Gender}";
        }
    }
}
