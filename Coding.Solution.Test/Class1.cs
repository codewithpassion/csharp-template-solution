namespace Coding.Solution
{
    using System;

    using Moq;

    using NUnit.Framework;

    [TestFixture]
    public class Foo
    {
        private string _testee;

        [SetUp]
        public void SetUp()
        {
            Mock<string> foo = new Mock<String>();
        } 
    }
}