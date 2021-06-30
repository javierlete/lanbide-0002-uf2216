using System;
using System.Runtime.Serialization;

namespace POO.Entidades
{
    [Serializable]
    public class EntidadesException : Exception
    {
        public EntidadesException()
        {
        }

        public EntidadesException(string message) : base(message)
        {
        }

        public EntidadesException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EntidadesException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}