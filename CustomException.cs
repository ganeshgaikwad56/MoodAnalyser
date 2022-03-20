using System.Runtime.Serialization;

namespace MoodAnalyser
{
    [Serializable]
    internal class CustomException : Exception
    {
        private object nULL_EXCEPTION;
        private string v;

        public CustomException()
        {
        }

        public CustomException(string? message) : base(message)
        {
        }

        public CustomException(object nULL_EXCEPTION, string v)
        {
            this.nULL_EXCEPTION = nULL_EXCEPTION;
            this.v = v;
        }

        public CustomException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public static object ExceptionType { get; internal set; }
    }
}