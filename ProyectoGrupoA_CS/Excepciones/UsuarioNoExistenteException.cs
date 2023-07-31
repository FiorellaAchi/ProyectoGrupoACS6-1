using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    [Serializable]
    internal class UsuarioNoExistenteException : Exception
    {
        public UsuarioNoExistenteException()
        {
        }

        public UsuarioNoExistenteException(string message) : base(message)
        {
        }

        public UsuarioNoExistenteException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public UsuarioNoExistenteException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}