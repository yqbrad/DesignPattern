using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IMemory camera = new CameraMemory();

            IMemory sd = new SdCardMemoryAdapter(new SdCardMemory());

            camera.Connect();
            camera.GetData();
            camera.SetData();

            Console.WriteLine("----------------");

            sd.Connect();
            sd.GetData();
            sd.SetData();

            Console.ReadLine();
        }
    }
}
