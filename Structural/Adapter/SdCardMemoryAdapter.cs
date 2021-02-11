namespace Adapter
{
    public class SdCardMemoryAdapter : IMemory
    {
        private readonly SdCardMemory _memory;
        public SdCardMemoryAdapter(SdCardMemory sd) => _memory = sd;

        public void Connect() => _memory.ConnectToDevice();

        public void GetData() => _memory.GetData();

        public void SetData() => _memory.Send();
    }
}