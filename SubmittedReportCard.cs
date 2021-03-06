using System;

namespace CodeLouisville.OOPExamples.ReportCards
{
    public class SubmittedReportCard : SignedReportCard
    {
        public SubmittedReportCard(SignedReportCard obj) : base(obj)
        {
            this.DateSigned = obj.DateSigned;
            this.ParentName = obj.ParentName;
            this.TitleCard = "\n============================="
            + "\nThe Submitted Report Card"
            + "\n=============================";
        }

        //the following properties are the only thing that differentiates me and a SignedReportCard
        //I'll inherit all public and protected properties from SignedReportCard
        public DateTime? DateSubmitted { get; set; }
        public string UniversityName { get; set; }

        //replacing the logic in SignedReportCard.ToString()
        public override string ToString()
        {
            var wasSubmitted = DateSubmitted.HasValue;

            return base.ToString()
            + (wasSubmitted ?
            $"\nSubmitted to {UniversityName ?? "<missing university name>"} on {DateSubmitted.Value.ToShortDateString()}"
            :
            "Unsubmitted")
            ;
        }
    }
}