using System;
using System.Collections.Generic;

public class Connection
{
    public bool IsInUse { get; set; }
    public void Use() => Console.WriteLine("Using connection");
}

public class ConnectionPool
{
    private List<Connection> _connections = new List<Connection>();

    public ConnectionPool(int size)
    {
        for (int i = 0; i < size; i++)
            _connections.Add(new Connection());
    }

    public Connection GetConnection()
    {
        foreach (var conn in _connections)
        {
            if (!conn.IsInUse)
            {
                conn.IsInUse = true;
                return conn;
            }
        }
        return null;
    }

    public void ReleaseConnection(Connection conn) => conn.IsInUse = false;
}