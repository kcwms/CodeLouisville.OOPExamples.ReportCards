namespace CodeLouisville.OOPExamples.ReportCards
{
    public class UnsignedReportCard : IReportCard
    {
        public decimal Grade { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClassName { get; set; }
        public string Instructor { get; set; }

        public override string ToString()
        {
            return $"Student:  {FirstName ?? "<first name>"} {LastName ?? "<last name>"}"
            + $"\nClass:  {ClassName ?? "<class name>"}"
            + $"\nInstructor:  {Instructor ?? ""}"
            + $"\nGPA:  {Grade}"
            ;
        }
    }
}