using System;
using System.Runtime.Serialization;

namespace ApiCatalogoJogos.Services
{
    [Serializable]
    internal class JogoCadastradoException : Exception
    {
        public JogoCadastradoException()
        {
        }

        public JogoCadastradoException(string message) : base(message)
        {
        }

        public JogoCadastradoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected JogoCadastradoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}