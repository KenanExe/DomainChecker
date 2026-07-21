using DomainChecker;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainChecker
{
    internal class SqlResults
    {
        public static bool AddResults(string name, bool Status)
        {
            string DbPath = ConfigurationManager.AppSettings["DbPath"];

            using (SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={DbPath};Version=3;"))
            {
                try
                {
                    m_dbConnection.Open();

                    string insertSql = "INSERT INTO TblResults (Name, Status) VALUES (@Name, @Status);";
                    using (SQLiteCommand insertCommand = new SQLiteCommand(insertSql, m_dbConnection))
                    {
                        insertCommand.Parameters.AddWithValue("@Name", name);
                        insertCommand.Parameters.AddWithValue("@Status", Status);
                        insertCommand.ExecuteNonQuery();
                    }
                }
                catch (SQLiteException ex)
                {
                    LoggingService.Log("DB Error: " + ex.Message);
                    return false;
                }
                return true;
            }
        }
    }
}