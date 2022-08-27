using System;

namespace Api_Platipus.Infrastructure.DataTransferObjects
{
    public class TestResult
    {
        public object Result { get; set; }

        public TestResult(object result)
        {
            Result = result;
        }
    }
}
