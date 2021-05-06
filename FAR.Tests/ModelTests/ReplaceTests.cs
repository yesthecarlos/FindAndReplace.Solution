using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FAR.Models;

namespace FAR.Test
{
  [TestClass]
  public class ReplacerTests
  {
 
    [TestMethod]
    public void Replace_HelloWorld_HelloUniverse()
    {

    
    // Arrange
    string userString = "";
    string wordToReplace = "";
    string newWord = "";
    Replacer testReplacer = new Replacer();
    // Act
    string stringMethod = testReplacer.Replace(userString, wordToReplace, newWord);
    string outputString = "Hello Universe";
    // Assert
    Assert.AreEqual( outputString, stringMethod );
    //input "Hello World"
    //output "Hello Universe"
    }
  }
}


// namespace Calendar.Tests
// {
//   [TestClass]
//   public class LeapYearTests
//   {
//     [TestMethod]
//     public void IsLeapYear_NumberDivisibleByFour_True()
//     {
//       LeapYear testLeapYear = new LeapYear();
//       Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));
//     }
//   }
// }

// namespace Calendar.Tests
// {
//   [TestClass]
//   public class LeapYearTests
//   {
//     [TestMethod]
//     public void IsLeapYear_NumberDivisibleByFour_True()
//     {
//       //testing code will go here
//     }
//   }
// }