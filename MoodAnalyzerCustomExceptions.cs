using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
   public class MoodAnalyzerCustomExceptions : Exception
    {
        public enum ExceptionType
        {
            NULL_MRSSAGE_EXCEPTION, EMPTY_MESSAGE_EXCEPTION, NO_SUCH_CLASS, NO_SUCH_METHOD
        }
        private readonly ExceptionType exceptionType;

        public MoodAnalyzerCustomExceptions(ExceptionType exceptionType, string exceptionMessage) : base(exceptionMessage)
        {
            this.exceptionType = exceptionType;
        }
    }
}
