using System;

namespace DatabaseConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString, TimeSpan timeOut) : base(connectionString, timeOut)
        {}

        public override void OpenConnection()
        {
            Console.WriteLine("Opening Orcale connection.");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing Orcale connection.");
        }
    }
}
