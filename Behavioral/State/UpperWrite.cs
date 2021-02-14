using System;

namespace State
{
    public class UpperWrite: IWritingState
    {
        public void Write(string words) => Console.WriteLine(words.ToUpper());
    }
}
