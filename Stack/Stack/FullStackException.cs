using System;
using System.Runtime.Serialization;

namespace ConsoleApplication1
{
    [Serializable]
    internal class FullStackException : Exception
    {
        public FullStackException() : base("Stack is full")
        {
        }

        public FullStackException(string message) : base(message)
        {
        }

        public FullStackException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FullStackException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}