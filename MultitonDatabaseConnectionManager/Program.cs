
using System;
namespace Zadanie
{
    public class Program
    {
        static void Main(string[] args)
        {
            DatabaseConnectionManager dbConnectionManager1 = DatabaseConnectionManager.GetConnection("Baza-test-1");
            DatabaseConnectionManager dbConnectionManager2 = DatabaseConnectionManager.GetConnection("Baza-test-2");
            DatabaseConnectionManager dbConnectionManager3 = DatabaseConnectionManager.GetConnection("Baza-test-3");

            if (dbConnectionManager1 != dbConnectionManager2
            && dbConnectionManager1 != dbConnectionManager3
            && dbConnectionManager2 != dbConnectionManager3)
            {
                System.Console.WriteLine("========");
                System.Console.WriteLine("All good, three different instances");
                System.Console.WriteLine("========");
                System.Console.WriteLine();
            }

            dbConnectionManager1.OpenConnection();
            dbConnectionManager1.OpenConnection();
            System.Console.WriteLine();

            dbConnectionManager2.OpenConnection();
            dbConnectionManager2.OpenConnection();
            System.Console.WriteLine();

            dbConnectionManager3.OpenConnection();
            dbConnectionManager3.OpenConnection();
            System.Console.WriteLine();

            dbConnectionManager1.CloseConnection();
            dbConnectionManager1.CloseConnection();
            System.Console.WriteLine();

            dbConnectionManager2.CloseConnection();
            dbConnectionManager2.CloseConnection();
            System.Console.WriteLine();

            dbConnectionManager3.CloseConnection();
            dbConnectionManager3.CloseConnection();
            System.Console.WriteLine();
        }
    }
}

