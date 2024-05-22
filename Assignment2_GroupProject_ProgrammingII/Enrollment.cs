using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_GroupProject_ProgrammingII
{
    public class Enrollment
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public static Enrollment FromCsv(string csvLine)
        {
            var values = csvLine.Split(',');
            return new Enrollment
            {
                ID = int.Parse(values[0]),
                StudentID = int.Parse(values[1]),
                CourseID = int.Parse(values[2]),
                EnrollmentDate = DateTime.Parse(values[3])
            };
        }

        public string ToCsv()
        {
            return $"{ID},{StudentID},{CourseID},{EnrollmentDate.ToShortDateString()}";
        }
    }
}

