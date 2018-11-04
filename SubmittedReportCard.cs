using System;

namespace CodeLouisville.OOPExamples.ReportCards
{
    public class SubmittedReportCard : SignedReportCard
    {
        public DateTime? DateSubmitted { get; set; }
        public string UniversityName { get; set; }

        public override string ToString()
        {
            var wasSubmitted = DateSubmitted.HasValue;

            return base.ToString()
            + (wasSubmitted?
            $"\nSubmitted to {UniversityName??"<missing university name>"} on {DateSubmitted.Value.ToShortDateString()}"
            :
            "Unsubmitted")
            ;
        }
    }
}