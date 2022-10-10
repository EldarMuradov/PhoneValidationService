namespace Test.App.Service
{
    public interface IService
    {
        void ReceiveMessage(ref string args, out bool isValid);
    }
}
