using System;

namespace Adapter
{
    public class CameraMemory : IMemory
    {
        public void Connect() => Console.WriteLine("Connected");

        public void GetData() => Console.WriteLine("Get Data");

        public void SetData() => Console.WriteLine("Set Data");
    }
}