namespace Test.App.Server
{
    public interface ISingleServerAdapter
    {
        void Init();
        void Shutdown();
        void Response();
        void Receive(string args);
    }
}
