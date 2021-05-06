using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FAR.Models;

namespace FAR.Test
{
  [TestClass]
  public class ReplacerTests : IDisposable
  {
    public void Dispose()
    {
      Replacer.ClearAll();
    }
    [TestMethod]
    public void ReplacerConstructorCreatesInstanceOfReplacer_Replacer()
    {
      Replacer newReplacer = new Replacer("test");
      Assert.AreEqual(typeof(Replacer), newReplacer.GetType());
    }

    //input "Hello World"
    //output "Hello Universe"



  }
}