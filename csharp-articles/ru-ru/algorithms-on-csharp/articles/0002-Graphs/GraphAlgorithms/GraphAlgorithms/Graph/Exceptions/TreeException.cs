using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.Graph.Exceptions
{
    public class TreeException : GraphException {

        public TreeException() { }

        public TreeException(string? message) : base(message) { }

        public TreeException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}
