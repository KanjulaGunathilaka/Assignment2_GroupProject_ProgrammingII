using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_GroupProject_ProgrammingII
{
    public class Course
    {
        public int ID { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }

        public static Course FromCsv(string csvLine)
        {
            var values = csvLine.Split(',');
            return new Course
            {
                ID = int.Parse(values[0]),
                CourseName = values[1],
                Credits = int.Parse(values[2])
            };
        }

        public string ToCsv()
        {
            return $"{ID},{CourseName},{Credits}";
        }
    }
}

