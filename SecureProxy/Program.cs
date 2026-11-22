
using System;
namespace Zadanie
{
    public class Program
    {
        static void Main(string[] args)
        {
            AccessProxy accessProxyWithAccess = new AccessProxy(new User(true));
            AccessProxy accessProxyWithoutAccess = new AccessProxy(new User(false));

            accessProxyWithAccess.ReadContent();
            accessProxyWithoutAccess.ReadContent();
        }
    }
}

