using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_GroupProject_ProgrammingII
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public static User FromCsv(string csvLine)
        {
            var values = csvLine.Split(',');
            return new User
            {
                ID = int.Parse(values[0]),
                FirstName = values[1],
                LastName = values[2]
            };
        }

        public string ToCsv()
        {
            return $"{ID},{FirstName},{LastName}";
        }
    }
}
}
