using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_8___Exception_Handling
{
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }
}
