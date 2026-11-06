using System;

namespace Valencia_Ryan_LabStream
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
