using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonoOptionParserSandbox;

namespace GeneralTests
{
    [TestClass]
    public class FunctionResultTest
    {
        [TestMethod]
        public void FunctionResult_Constructions_Succeed()
        {
            // Boolean value type results
            var r1 = FunctionResult<bool>.Success(true);

            Assert.IsNotNull(r1);
            Assert.IsTrue(r1.Value);
            Assert.IsTrue(r1.Successful);

            var r2 = FunctionResult<bool>.Success(false);

            Assert.IsNotNull(r2);
            Assert.IsFalse(r2.Value);
            Assert.IsTrue(r2.Successful);

            var rFail = FunctionResult<bool>.Failure();

            Assert.IsNotNull(rFail);
            Assert.IsFalse(rFail.Value);
            Assert.IsFalse(rFail.Successful);

            // Nonspecific refernce type object result
            var r3 = FunctionResult<object>.Success(new object());

            Assert.IsNotNull(r3);
            Assert.IsNotNull(r3.Value);
            Assert.IsTrue(r3.Successful);
        }
    }
}
