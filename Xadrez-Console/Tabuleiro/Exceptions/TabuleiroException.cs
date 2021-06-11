using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez_Console.Tabuleiro.Exceptions
{
    [Serializable]
    public class TabuleiroException : Exception
    {
        public TabuleiroException(string message) : base(message)
        {
        }

        protected TabuleiroException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
