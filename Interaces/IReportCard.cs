
namespace CodeLouisville.OOPExamples.ReportCards
{
    public interface IReportCard
    {
        decimal Grade { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string ClassName{get;set;}
        string Instructor{get;set;}
    }
}