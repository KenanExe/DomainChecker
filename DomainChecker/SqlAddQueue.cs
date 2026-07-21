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
    internal class SqlAddQueue
    {
        public static void AddQueue(string name)
        {
            string DbPath = ConfigurationManager.AppSettings["DbPath"];
            using (SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={DbPath};Version=3;"))
            {
                try
                {
                    m_dbConnection.Open();

                    //Check if the name already exists in TblQueue or TblChecked
                    string checkSql = @"
                                        SELECT EXISTS(
                                        SELECT 1 FROM TblQueue WHERE Name = @Name
                                        UNION ALL
                                        SELECT 1 FROM TblResults WHERE Name = @Name
                                        );";

                    using (SQLiteCommand checkCommand = new SQLiteCommand(checkSql, m_dbConnection))
                    {
                        checkCommand.Parameters.AddWithValue("@Name", name);

                        // Check if the name exists in either table
                        long exists = (long)checkCommand.ExecuteScalar();

                        if (exists > 0)
                        {
                            LoggingService.Log($"'{name}' already exists in the queue or main database, not added.");
                            return;
                        }
                    }
                    string insertSql = "INSERT INTO TblQueue (Name) VALUES (@Name);";
                    using (SQLiteCommand insertCommand = new SQLiteCommand(insertSql, m_dbConnection))
                    {
                        insertCommand.Parameters.AddWithValue("@Name", name);
                        insertCommand.ExecuteNonQuery();
                    }
                }
                catch (SQLiteException ex)
                {
                    LoggingService.Log("DB Error: " + ex.Message);
                }
            }
        }
    }
}