using System;
using System.Runtime.Serialization;

namespace Assignment3
{
    [Serializable]
    internal class CannotRemoveException : Exception
    {
        public CannotRemoveException()
        {
        }

        public CannotRemoveException(string message) : base(message)
        {
        }

        public CannotRemoveException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CannotRemoveException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}