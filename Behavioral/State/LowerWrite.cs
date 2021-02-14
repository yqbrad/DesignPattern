using System;

namespace State
{
    public class LowerWrite: IWritingState
    {
        public void Write(string words) => Console.WriteLine(words.ToLower());
    }
}