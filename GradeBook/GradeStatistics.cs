using System;


namespace Grades
{
	class GradeStatistics
	{
	
		public GradeStatistics()
		{
			HighestGrade = float.MinValue;
			LowestGrade = float.MaxValue;
		}
		public float AverageGrade;
		public float HighestGrade;
		public float LowestGrade;
	
	}

}