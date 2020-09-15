using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Evaluation.UnitTests
{
    [TestFixture]
    public class StackTests
    {

        private Evaluation.Stack<string> stack;

        [SetUp]
        public void SetUp()
        {
            this.stack = new Evaluation.Stack<string>();
        }

        [Test]
        public void Pop_WhenCalled_StackEmpty_ThrowsInvalidOperationException()
        {
            Assert.That(()=> { stack.Pop(); },Throws.Exception.TypeOf<InvalidOperationException>());
            Assert.That(()=> { stack.Pop(); },Throws.TypeOf<InvalidOperationException>());
        }

        [Test]
        [TestCase("abc","abc")]
        public void Pop_StackHasContent_ReturnsLastEntered(string input,string expectedresult)
        {
            stack.Push(input);
            var result = stack.Pop();
            Assert.That(result, Is.EqualTo(expectedresult));

        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            var result = stack.Count;
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        [TestCase("abc",1)]
        public void Push_WhenInsertValue_ReturnCount(string input,int expectedResult)
        {
            stack.Push(input);
            var result = stack.Count;
            Assert.That(result, Is.EqualTo(expectedResult));

        }

        [Test]
        public void Push_InsertNull_Throws_NullArgumentException()
        {
            
            Assert.That(()=> { stack.Push(null); },Throws.ArgumentNullException);
        }

        [Test]
        public void Peek_WhenEmpty_ThrowsInvalidOperationException()
        {
            Assert.That(()=> { stack.Peek(); },Throws.InvalidOperationException);
        }

        [Test]
        [TestCase("abc", "abc")]
        public void Peek_HasContent_ReturnLastEntered(string input, string expectedResult)
        {
            stack.Push(input);
            var result = stack.Peek();
               Assert.That(result, Is.EqualTo(expectedResult));

        }
        [Test]
        [TestCase("abc", 1)]
        public void Peek_HasContent_ElementNotRemoved_ReturnCount(string input, int expectedResult)
        {
            stack.Push(input);
            var item = stack.Peek();
            var result = stack.Count;
            Assert.That(result, Is.EqualTo(expectedResult));

        }
    }
}
