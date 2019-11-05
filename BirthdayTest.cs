using System;

[TestFixture]
public class SolutionTest {
	//
	// /!\ Unit Tests are optional but highly recommended /!\
	//
	// First Example
	//
	//[Test]
	//public void ExampleTest() {
	//	Assert.AreEqual("this is an example", "this is an example");
	//}

	//
	// Second Example
	//
	[Test]
	public void PrepareDateTestOk() {
		
		Assert.AreEqual("2016-01-01", Solution.PrepareDate("01-01").ToString("yyyy-MM-dd"));
	}
	
	[Test]
	public void PrepareDateTestFail() {
		
		var ex = Assert.Throws<System.FormatException>(() => Solution.PrepareDate("2019-01-01").ToString("yyyy-MM-dd"));
		Assert.That(ex.Message, Is.EqualTo("String was not recognized as a valid DateTime."));
		
	}
	
	[Test]
	public void WeekendInNext50YearsOk() {
		
		Assert.AreEqual("Sat-2020 Sun-2021 Fri-2025 Sat-2026 Sun-2027 Fri-2031 Sun-2032 Fri-2036 Sat-2037 Sun-2038 Fri-2042 Sat-2043 Sat-2048 Sun-2049 Fri-2053 Sat-2054 Sun-2055 Fri-2059 Sun-2060 Fri-2064 Sat-2065 ", Solution.WeekendInNext50Years(Convert.ToDateTime("2016-05-02")));
		
	}
	
}
