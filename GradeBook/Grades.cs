using System;


class Grades
{
	class Program
	{
		static void Main(string[] args)
		{
			GradeBook book = new GradeBook();
			book.AddGrade(91);
			book.AddGrade(89.5f);
			book.AddGrade(75);
			
			
			GradeStatistics stats = book.ComputeStatistics;
			
			Console.WriteLine(stats.AverageGrade);
			Console.WriteLine(stats.HighestGrade);
			Console.WriteLine(stats.LowestGrade);
			
			//book = new GradeBook(); //creates second instance of GradeBook only have access to this instance
									//because it only points to book
			//book.AddGrade(75);
			
			//GradeBook book2 = book; points back to book append 60 to books
			//book2.AddGrade(60); 
		}
	}
	
}