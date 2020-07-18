using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select what you would like to do by typing the number of the command: " +
                "\n 1. Execute SQL instructions" +
                "\n 2. Execute Orcale instructions" +
                "\n 3. Exit Application");

            var sql = new SqlConnection("SQL connection established", new TimeSpan(1, 1, 1));
            var orc = new OracleConnection("Orcale connection established", new TimeSpan(1, 1, 1));
            var sqlcmd = new DbCommand(sql, "SQL instructions executed.");
            var orccmd = new DbCommand(orc, "Orcale instructions executed.");

            while (true)
            {
                try
                {
                    var input = Console.ReadLine();

                    switch (input.ToString())
                    {
                        case "1":
                            sqlcmd.Execute();
                            break;
                        case "2":
                            orccmd.Execute();
                            break;
                        case "3":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("I dont know that command. Please select what you would like to do by typing the number of the command.");
                            break;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
