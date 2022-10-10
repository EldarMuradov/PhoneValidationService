using System;
using Test.App.Server;
using Test.App.Service;

namespace Test
{
    public sealed class SingleServerAdapter<TSource> : ISingleServerAdapter where TSource : IService
    {
        public SingleServerAdapter(TSource service) => _service = service;

        #region Vars

        public bool IsRun { get; private set; }

        private readonly TSource _service;

        #endregion

        #region Methods

        public void Init() => IsRun = true;

        public void Response() => Console.WriteLine("Error: 404");

        public void Shutdown() 
        {
            IsRun = false;
            Console.WriteLine("System shuted down!");
        }

        public void Receive(string args)
        {
            bool isValid;
            if (args != "exit")
            {
                _service.ReceiveMessage(ref args, out isValid);
                if (!isValid)
                    Response();
            }
            else
                Shutdown();
        }

        #endregion
    }
}
