namespace Assignment2_GroupProject_ProgrammingII
{
    public class Teacher : User
    {
        public string Subject { get; set; }

        public static new Teacher FromCsv(string csvLine)
        {
            var values = csvLine.Split(',');
            return new Teacher
            {
                ID = int.Parse(values[0]),
                FirstName = values[1],
                LastName = values[2],
                Subject = values[3]
            };
        }

        public new string ToCsv()
        {
            return $"{ID},{FirstName},{LastName},{Subject}";
        }
    }
}
