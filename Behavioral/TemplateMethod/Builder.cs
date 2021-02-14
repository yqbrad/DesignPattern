namespace TemplateMethod
{
    public abstract class Builder
    {
        public abstract void Compile();

        public abstract void Test();

        public abstract void Deploy();

        public void Build()
        {
            Compile();
            Test();
            Deploy();
        }
    }
}