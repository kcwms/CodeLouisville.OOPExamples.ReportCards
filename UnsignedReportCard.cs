namespace CodeLouisville.OOPExamples.ReportCards
{
    public class UnsignedReportCard : IReportCard
    {
        public UnsignedReportCard()
        {
            this.TitleCard = "\n============================="
+ "\nThe Unsigned Report Card"
+ "\n=============================";
        }
        public decimal Grade { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClassName { get; set; }
        public string Instructor { get; set; }

        public virtual string TitleCard { get; set; }

        //replacing the logic in Object.ToString()
        public override string ToString()
        {
            return $"\nStudent:  {FirstName ?? "<first name>"} {LastName ?? "<last name>"}"
            + $"\nClass:  {ClassName ?? "<class name>"}"
            + $"\nInstructor:  {Instructor ?? ""}"
            + $"\nGPA:  {Grade}"
            ;
        }
    }
}