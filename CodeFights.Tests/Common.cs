using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.Tests.Common
{
    public class ComplexTest<T, TK>
    {
        public ComplexTest()
        {
            
        }
        public ComplexTest(T input, TK expectedResult)
        {
            Input = input;
            ExpectedResult = expectedResult;
        }
        public T Input { get; set; }
        public TK ExpectedResult { get; set; }
    }
}
