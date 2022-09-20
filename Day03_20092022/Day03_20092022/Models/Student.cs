namespace Day03_20092022.Models
{
    public class Student
    {
        public string StudentID { get; set; }

        public string FullName { get; set; }

        public double Grade { get; set; }

        public string Rank
        {
            get
            {
                if (Grade >= 8.5) return "A";
                if (Grade >= 7.8) return "B";
                if (Grade >= 5) return "C";
                return "D";
            }
        }
    }
}
