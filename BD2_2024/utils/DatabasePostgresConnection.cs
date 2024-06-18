using System;
using Npgsql;

namespace PostgresConnectionExample
{
    public sealed class DatabasePostgresConnection
    {
        private static DatabasePostgresConnection _instance = null;
        private static readonly object _lock = new object();
        private NpgsqlConnection _connection;
        private string _connectionString;

        private DatabasePostgresConnection(string connectionString)
        {
            _connectionString = connectionString;
            _connection = new NpgsqlConnection(_connectionString);
            _connection.Open();
        }

        public static DatabasePostgresConnection GetInstance(string connectionString = null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    if (connectionString == null)
                    {
                        throw new InvalidOperationException("A conexão ainda não foi inicializada.");
                    }
                    _instance = new DatabasePostgresConnection(connectionString);
                }
                return _instance;
            }
        }

        public NpgsqlConnection GetConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed || _connection.State == System.Data.ConnectionState.Broken)
            {
                _connection = new NpgsqlConnection(_connectionString);
                _connection.Open();
            }
            return _connection;
        }

        public void CloseConnection()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}
