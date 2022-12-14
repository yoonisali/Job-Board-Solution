using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobBoard.Models;

namespace JobBoard.Tests
{
  [TestClass]
  public class JobBoard
  {
    [TestMethod]
    public void JobConstructor_CreatesInstanceOfJobBoard_Job()
      {
        Jobs newJob = new Jobs("s", "s", "s", "s");
        Assert.AreEqual(typeof(Jobs), newJob.GetType());
      }
  }
}
    