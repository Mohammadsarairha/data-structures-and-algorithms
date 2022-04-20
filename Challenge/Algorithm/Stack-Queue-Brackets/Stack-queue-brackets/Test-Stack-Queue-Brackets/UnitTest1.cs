using System;
using Xunit;
using Stack_queue_brackets;

namespace Test_Stack_Queue_Brackets
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{}")]
        [InlineData("{}(){}")]
        [InlineData("()[[Extra Characters]]")]
        [InlineData("(){}[[]]")]
        [InlineData("{}{Code}[Fellows](())")]
        public void Test1(string inputString)
        {
            Assert.True(Program.ValidateBrackets(inputString));
        }

        [Theory]
        [InlineData("[({}]")]
        [InlineData("(](")]
        [InlineData("{(})")]
        [InlineData("(")]
        [InlineData("{}{Code}[Fellows](()){)")]
        [InlineData("")]
        public void Test2(string inputString)
        {
            Assert.False(Program.ValidateBrackets(inputString));
        }
    }
}
