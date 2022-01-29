using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HT.Martian.Robots.Core.Core.Models.Exceptions
{
    public class FailInitEnvException : Exception
    {
        public FailInitEnvException() { }
        public FailInitEnvException(string message):base(message)
        {
        }
        public FailInitEnvException(string message, Exception innerException) : base(message, innerException) 
        { }
        protected FailInitEnvException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }

    }
}
