using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonoOptionParserSandbox;

namespace GeneralTests
{
    [TestClass]
    public class ExtensionTests
    {
        [TestMethod]
        public void ParseIntFunctionally()
        {
            var r1 = "777".ParseInt32();

            Assert.IsNotNull(r1);
            Assert.IsTrue(r1.Successful);
            Assert.AreEqual(777, r1.Value);
        }

        [TestMethod]
        public void ParseDelimitedStringToList()
        {
            var r1 =  "Eat,at,Joes".AsDelimitedToList();

            Assert.IsNotNull(r1);
            Assert.IsTrue(r1.Count == 3);

        }
    }
}
