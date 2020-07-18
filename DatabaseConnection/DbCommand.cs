using System;

namespace DatabaseConnection
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instructions;

        public DbCommand(DbConnection dbConnection, string instructions)
        {
            if (string.IsNullOrWhiteSpace(dbConnection.ConnectionString))
                throw new Exception("Instructions must not be null.");

            if (dbConnection == null)
                throw new Exception("Connection must not be null.");

            _dbConnection = dbConnection;
            _instructions = instructions;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine(_instructions);
            _dbConnection.CloseConnection();
        }
    }
}
