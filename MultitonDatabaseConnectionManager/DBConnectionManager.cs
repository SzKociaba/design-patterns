using System;
using System.Collections.Generic;

namespace Zadanie
{
    public class DatabaseConnectionManager
    {
        /* Słownik przechowujący instancje połączeń do baz danych Twoja implementacja*/
        private static Dictionary<string, DatabaseConnectionManager> dbConnections = new Dictionary<string, DatabaseConnectionManager>();

        public bool IsConnected { get; private set; }
        public string Database { get; private set; }

        /* Prywatny konstruktor Twoja implementacja*/
        private DatabaseConnectionManager(string dbName)
        {
            Database = dbName;
        }

        /* Metoda zwracająca połączenie do odpowiedniej bazy danych Twoja implementacja*/
        public static DatabaseConnectionManager GetConnection(string dbName)
        {
            if (!dbConnections.ContainsKey(dbName))
            {
                dbConnections[dbName] = new DatabaseConnectionManager(dbName);
            }
            return dbConnections[dbName];
        }

        // Otwieranie połączenia
        public void OpenConnection()
        {
            if (IsConnected)
            {
                System.Console.WriteLine($"Connection to {Database} already established.");
                return;
            }
            IsConnected = true;
            System.Console.WriteLine($"Successfully connected to {Database}");
        }

        // Zamykanie połączenia
        public void CloseConnection()
        {
            if (!IsConnected)
            {
                System.Console.WriteLine($"Connection to {Database} already closed.");
                return;
            }
            IsConnected = false;
            System.Console.WriteLine($"Successfully closed connection to {Database}");
        }
    }
}

