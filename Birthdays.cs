using System;

public class Solution {
	
	static public int YEAR = 2016;
	static public string SEPARATOR = "-";
	static public string SPACE = " ";
	static public int YEARINCREMENT = 1;
	static public int LEAPYEARINCREMENT = 4;
	
    static public string Run(string birthday_date) {
        //
		// Some work here; return type and arguments should be according to the problem's requirements
		//
		
		return WeekendInNext50Years(PrepareDate(birthday_date));
	}
	
	static public DateTime PrepareDate(string date)
	{
		string outdate = YEAR.ToString() + SEPARATOR + date.Split('-')[1] + SEPARATOR + date.Split('-')[0];
		Console.WriteLine(outdate);
		return Convert.ToDateTime(outdate);
	}
	
	static public string WeekendInNext50Years(DateTime date)
	{
		string output = "";
		int increment = YEARINCREMENT;
		if(date.ToString("yyyy-MM-dd") == "2016-02-29")
		{
			increment = LEAPYEARINCREMENT;
		}
		
		for (int i = 0; i< 50; i+=increment)
		{
			date = (i == 0 ? date : date.AddYears(increment));
			DayOfWeek day = date.DayOfWeek;
			
			if ((day == DayOfWeek.Saturday) || (day == DayOfWeek.Sunday)
				|| day == DayOfWeek.Friday)
			{
				Console.WriteLine(date.ToString());
				
			    output += date.ToString("ddd-yyyy") + SPACE;
			}
		}
		return output;
	}
	
}
