using System;

public class DatabaseManager
{
    private static DatabaseManager _instance;
    private static readonly object _lock = new object();

    private DatabaseManager() {}

    public static DatabaseManager Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                    _instance = new DatabaseManager();
                return _instance;
            }
        }
    }

    public void Connect() => Console.WriteLine("Connected to DB");
}