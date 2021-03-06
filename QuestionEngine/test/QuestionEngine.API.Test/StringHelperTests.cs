﻿using NUnit.Framework;
using QuestionEngine.API.Support;

namespace QuestionEngine.API.Test
{
    [TestFixture]
    public class StringHelperTests
    {
        [Test]
        public void should_return_decoded_string()
        {
            const string input = "Test~~AMP~~Test";
            var output = StringHelper.DecodeAmpersands(input);
            Assert.That(output, Is.EqualTo("Test&Test"));
        }
    }
}
