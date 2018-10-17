using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonoOptionParserSandbox;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GeneralTests
{
    [TestClass]
    public class DelegationTests
    {
        static bool didNothing = false;

        [TestMethod]
        public void OptionDelegates_Succeed()
        {
            var uut = new OptionDelegate( new List<string>{ "happy" }, DoNothing );

            Assert.IsNotNull(uut);

            uut.Invoke();

            Assert.IsTrue(didNothing);
        }

        public static void DoNothing()
        {
            Thread.Sleep(1);

            didNothing = true;
        }
    }
}
