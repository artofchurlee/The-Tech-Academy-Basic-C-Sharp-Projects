using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    public class CustomException: Exception
    {
        public CustomException()
            : base() { }
        public CustomException(string message)
            : base(message) { }
    }
    public class CustomException2: Exception
    {
        public CustomException2()
            : base() { }
        public CustomException2(string message)
            : base(message) { }
    }
}
