using System;
using System.Runtime.Serialization;

namespace PCBuilder
{
    [Serializable]
    internal class PCNotWorkingException : Exception
    {
        public PCNotWorkingException()
        {
        }

        public PCNotWorkingException(string message) : base(message)
        {
        }

        public PCNotWorkingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PCNotWorkingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}