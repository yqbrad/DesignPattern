using System;

namespace State
{
    class DefaultWrite: IWritingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words);
        }
    }
}