

[TestFixture]
public class SolutionTest {
	//
	// /!\ Unit Tests are optional but highly recommended /!\
	//
	// First Example
	//
	[Test]
	public void VerifyInputFail() {
		
		var ex = Assert.Throws<System.InvalidOperationException>(() => Solution.VerifyInput(10001));
		Assert.That(ex.Message, Is.EqualTo(Solution.NUMBER_OVERFLOW_MESSAGE));
		
	}
	
	[Test]
	public void ArabicToRomanOkOne() {
		
		Assert.AreEqual(Solution.ArabicToRoman(1),"I");
		
	}
	
	[Test]
	public void ArabicToRomanOk4999() {
		
		Assert.AreEqual(Solution.ArabicToRoman(3999),"MMMCMXCIX");
		
	}
	
	[Test]
	public void ArabicToRomanOk9999() {
		
		Assert.AreEqual(Solution.ArabicToRoman(9999),"MMMMMMMMMCMXCIX");
		
	}
}
