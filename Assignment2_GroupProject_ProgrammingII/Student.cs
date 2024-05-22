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

        public static new Student FromCsv(string csvLine)
        {
            var values = csvLine.Split(',');
            return new Student
            {
                ID = int.Parse(values[0]),
                FirstName = values[1],
                LastName = values[2],
                DateOfBirth = DateTime.Parse(values[3]),
                Gender = values[4]
            };
        }

        public new string ToCsv()
        {
            return $"{ID},{FirstName},{LastName},{DateOfBirth.ToShortDateString()},{Gender}";
        }
    }
}
