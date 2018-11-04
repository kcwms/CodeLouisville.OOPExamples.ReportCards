using System;

namespace CodeLouisville.OOPExamples.ReportCards
{
    public class SignedReportCard : UnsignedReportCard
    {
        public SignedReportCard(UnsignedReportCard obj)
        {
            this.ClassName = obj.ClassName;
            this.FirstName = obj.FirstName;
            this.LastName = obj.LastName;
            this.Grade = obj.Grade;
            this.Instructor = obj.Instructor;
            this.TitleCard = "\n============================="
            + "\nThe Signed Report Card"
            + "\n=============================";
        }
        
        //the following properties are the only thing that differentiates me from an UnsignedReportCard
        //I'll inherit all public and protected properties from UnsignedReportCard
        public DateTime? DateSigned { get; set; }
        public string ParentName { get; set; }


        //replacing the logic in UnsignedReportCard.ToString()
        public override string ToString()
        {
            var isSigned = !string.IsNullOrWhiteSpace(ParentName) && DateSigned.HasValue;

            return base.ToString()
            + (isSigned ? $"\nSigned by {ParentName} on {DateSigned.Value.ToShortDateString()}" : "\nMissing Valid Signature and/or Date");
        }
    }
}