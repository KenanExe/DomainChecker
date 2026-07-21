using System.Configuration;
using System.Data.SQLite;
namespace DomainChecker
{
    internal class SqlCrateDataBase
    {
        static public void CreateDatabase()
        {
            string DbPath = ConfigurationManager.AppSettings["DbPath"];

            bool DebugMode = ConfigurationManager.AppSettings["DebugMode"] == "true";
            if (!System.IO.File.Exists(DbPath))
            {
                SQLiteConnection.CreateFile(DbPath);
            }
            else
            {
                if (DebugMode)
                {
                    System.IO.File.Delete(DbPath);
                }
                else
                {
                    return;
                }
            }
            using (SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={DbPath};Version=3;"))
            {
                try
                {
                    string SqlCreateTable = "create table if not exists TblResults (" +
                                            "Name text not null," +
                                            "Status boolean not null" +
                                            ");" +
                                            "create table if not exists TblQueue (" +
                                            "Name text not null" +
                                            ");";
                    m_dbConnection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(SqlCreateTable, m_dbConnection))
                    {
                        command.ExecuteNonQuery();
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
