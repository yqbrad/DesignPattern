using System;

namespace Adapter
{
    class Program
    {
        //Convert the interface of a class into another interface expect.
        //Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
        static void Main(string[] _)
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