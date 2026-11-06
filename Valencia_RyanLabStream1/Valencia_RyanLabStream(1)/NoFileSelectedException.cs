using System;

namespace Valencia_RyanLabStream_1
{
    public class NoFileSelectedException : Exception
    {
        public NoFileSelectedException() : base("No file was selected.")
        {
        }

        public NoFileSelectedException(string message) : base(message)
        {
        }
    }
}
