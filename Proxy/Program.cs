
using System;
namespace Zadanie
{
    public class Program
    {
        static void Main(string[] args)
        {
            ImageProxy imageProxy = new ImageProxy("SomeFIleName");
            imageProxy.Display();
            imageProxy.Display();
            imageProxy.Display();
            imageProxy.Display();
        }
    }
}

