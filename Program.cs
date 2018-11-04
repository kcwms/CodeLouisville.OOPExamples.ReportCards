using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodeLouisville.OOPExamples.ReportCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var reportCards = Program.GetAllReportCards();

            //polymorphism and inheritanse allows us to
            //to write this one piece of logic
            //that behaves 
            foreach (var rptCard in reportCards)
            {
                Console.WriteLine(rptCard.TitleCard);
                Console.WriteLine(rptCard.ToString());
                Console.WriteLine();
            }

            Console.WriteLine("enter to close");
            Console.ReadLine();
        }

        static IList<IReportCard> GetAllReportCards()
        {
            List<IReportCard> reportCards = new List<IReportCard>();
            
           var rptCard =new UnsignedReportCard(){
                     ClassName = "History"
                     ,Instructor = "Dr. Jones"
                     ,Grade = 3.4M
                     ,FirstName = "Peter"
                     ,LastName = "Parker"};

            var signedRptCard = new SignedReportCard(rptCard);
             signedRptCard.DateSigned = new DateTime(2018,7,5);
             signedRptCard.ParentName = "Uncle Ben";

             var submittedRptCard = new SubmittedReportCard(signedRptCard);
             submittedRptCard.UniversityName = "American University";
             submittedRptCard.DateSubmitted = new DateTime(2018,10,16);
             
             reportCards.Add(rptCard);
             reportCards.Add(signedRptCard);
             reportCards.Add(submittedRptCard);

             return reportCards;
        }
    }
}
