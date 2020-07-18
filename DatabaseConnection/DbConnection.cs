using System;

namespace DatabaseConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan TimeOut { get; private set; }

        public DbConnection(string connectionString, TimeSpan timeOut)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
                throw new Exception("ConnectionString must not be null.");

            ConnectionString = connectionString;
            TimeOut = timeOut;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}
