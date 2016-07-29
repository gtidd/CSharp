using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //SpeechSynthesizer synth = new SpeechSythesizer();
            //synth.Speak("Hello, this is the grade book program"); 


            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);


            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("average Grade: " + stats.AverageGrade);
            Console.WriteLine("highest Grade: " + stats.HighestGrade);
            Console.WriteLine("lowest Grade: " + stats.LowestGrade);

            //book = new GradeBook(); //creates second instance of GradeBook only have access to this instance
            //because it only points to book
            //book.AddGrade(75);

            //GradeBook book2 = book; points back to book append 60 to books
            //book2.AddGrade(60); 
        }
    }
}
