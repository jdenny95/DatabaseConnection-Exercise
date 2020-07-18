using System;

namespace DatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString, TimeSpan timeOut) : base(connectionString, timeOut)
        { }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening SQL connection.");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing SQL connection.");

        }
    }
}
