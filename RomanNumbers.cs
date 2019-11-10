  
using System;

public class Solution {
	
	private static int MAX_NUMBER_SUPPORTED = 9999;
	public static string NUMBER_OVERFLOW_MESSAGE = "Lack of characters provided in the exercise to describe Roman numbers over 9999.";
	
	private static string[] Thousands = { "", "M", "MM", "MMM", "MMMM", "MMMMM", "MMMMMM", "MMMMMMM", "MMMMMMMM", "MMMMMMMMM" };
	private static string[] Hundreds =
	    { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
	private static string[] Tens =
	    { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
	private static string[] Ones =
	    { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
	
    static public string Run(int n) {
        //
		// Some work here; return type and arguments should be according to the problem's requirements
		//
		VerifyInput(n);
		
		return ArabicToRoman(n);
	}
	
	static public void VerifyInput(int n)
	{
		if (n > MAX_NUMBER_SUPPORTED)
        {
            throw new System.InvalidOperationException(NUMBER_OVERFLOW_MESSAGE);
        }
	}
	
	static public string ArabicToRoman(int n)
	{
	    string result = "";
	    int num = 0;
	    num = n / 1000;
	    result += Thousands[num];
	    n %= 1000;
	
	    num = n / 100;
	    result += Hundreds[num];
	    n %= 100;
	
	    num = n / 10;
	    result += Tens[num];
	    n %= 10;
	
	    result += Ones[n];
	
	    return result;
	}
}
