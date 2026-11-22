namespace Zadanie
{
    public class RemoteServiceProxy : IRemoteService
    {
        RealRemoteService? realRemoteService = null;
        bool isConnected = false;

        public void GetData()
        {
            if (!isConnected)
            {
                this.realRemoteService = new RealRemoteService();
                realRemoteService.GetData();
                this.isConnected = true;
            }
            else
            {
                this._getDataFromCache();
            }
        }

        private void _getDataFromCache()
        {
            System.Console.WriteLine("Getting data from cache...");
        }
    }
}