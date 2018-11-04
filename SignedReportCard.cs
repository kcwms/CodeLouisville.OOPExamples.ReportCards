using System;

namespace CodeLouisville.OOPExamples.ReportCards
{
    public class SignedReportCard : IReportCard
    {
        public decimal Grade { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClassName { get; set; }
        public string Instructor { get; set; }

        public DateTime? DateSigned { get; set; }
        public string ParentName { get; set; }

        public override string ToString()
        {
            var isSigned = !string.IsNullOrWhiteSpace(ParentName) && DateSigned.HasValue;

            return $"Student:  {FirstName ?? "<first name>"} {LastName ?? "<last name>"}"
            + $"\nClass:  {ClassName ?? "<class name>"}"
            + $"\nInstructor:  {Instructor ?? ""}"
            + $"\nGPA:  {Grade}"
            + (isSigned ? $"\nSigned by {ParentName} on {DateSigned.Value.ToShortDateString()}" : "\nMissing Valid Signature and/or Date");
        }
    }
}