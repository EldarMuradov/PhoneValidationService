namespace Test.App.Service
{
    public interface IValidator: IService
    {
        void IsValid(ref string input, out bool isValid);
    }
}
