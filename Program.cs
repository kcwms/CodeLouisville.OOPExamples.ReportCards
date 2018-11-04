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
            foreach (var rptCard in reportCards)
            {
                string cardType = "";                
                if(rptCard is SignedReportCard)
                    cardType = "Signed";
                if(rptCard is UnsignedReportCard)
                    cardType = "Unsigned";
                if(rptCard is SubmittedReportCard)
                    cardType = "Submitted";

                Console.WriteLine("=============================");
                Console.WriteLine($"The {cardType} Report Card:");
                Console.WriteLine("=============================");
                Console.WriteLine(rptCard.ToString());
                Console.WriteLine();
            }
            Console.WriteLine("enter to close");
            Console.ReadLine();
        }

        static IList<IReportCard> GetAllReportCards()
        {
            List<IReportCard> reportCards = new List<IReportCard>();
            
            reportCards.Add(
                new SignedReportCard(){ClassName = "Physics"
                ,Instructor = "Dr. Knobbs"
                ,Grade = 1.75M
                ,FirstName = "Tony"
                ,LastName = "Stark"
                ,DateSigned = new DateTime(2018,11,2)
                ,ParentName = "Mr. Stark"}
             );
             
             reportCards.Add(
                 new UnsignedReportCard(){
                     ClassName = "History"
                     ,Instructor = "Dr. Jones"
                     ,Grade = 3.4M
                     ,FirstName = "Peter"
                     ,LastName = "Parker"}
             );

             reportCards.Add(
                 new SubmittedReportCard(){
                     ClassName = "Basket Weaving"
                     ,Instructor = "The Artist"
                     ,Grade = 4.00M
                     ,FirstName = "Steve"
                     ,LastName = "Rodgers"
                     ,ParentName = "Bucky Barnes"
                     ,DateSigned = new DateTime(1945,7,4)
                     ,UniversityName = "American University"
                     ,DateSubmitted = new DateTime(1945, 6,6)
                 }
             );
             
             return reportCards;
        }
    }
}
