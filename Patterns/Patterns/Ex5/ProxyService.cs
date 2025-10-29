namespace Patterns.Ex5
{
    internal class ProxyService : IService
    {
        private RealService _realService;

        public ProxyService(RealService realService)
        {
            _realService = realService;
        }

        public string GetData(string request)
        {
            throw new NotImplementedException();
        }
    }
}
