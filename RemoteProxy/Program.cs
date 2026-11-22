
using System;
namespace Zadanie
{
    public class Program
    {
        static void Main(string[] args)
        {
            RemoteServiceProxy remoteServiceProxy = new RemoteServiceProxy();
            remoteServiceProxy.GetData();
            remoteServiceProxy.GetData();
            remoteServiceProxy.GetData();
            remoteServiceProxy.GetData();
        }
    }
}

