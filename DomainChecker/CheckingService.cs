using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DomainChecker
{
    internal class CheckingService
    {
        static bool DebugMode = ConfigurationManager.AppSettings["DebugMode"] == "true";
        public static void StartChecking() // To Do: Make a loop for checking all items in the queue and add a delay between each check
        {
            string dbPath = ConfigurationManager.AppSettings["DbPath"];
            string connectionString = $"Data Source={dbPath};Version=3;";

            string itemName = null;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectSql = "SELECT Name FROM TblQueue ORDER BY rowid ASC LIMIT 1;";

                    using (SQLiteCommand selectCmd = new SQLiteCommand(selectSql, connection))
                    using (SQLiteDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            itemName = reader["Name"].ToString();
                        }
                        else
                        {
                            return;
                        }
                    }
                    bool isSuccess = CheckDomain(itemName);

                    if (isSuccess)
                    {
                        string deleteSql = "DELETE FROM TblQueue WHERE Name = @Name;";
                        using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteSql, connection))
                        {
                            deleteCmd.Parameters.AddWithValue("@Name", itemName);
                            deleteCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        LoggingService.Log($"{itemName} Error on checking domain.\n Maybe problem is rate limit\n Try speed down on checking speed");
                    }
                }
                catch (Exception ex)
                {
                    LoggingService.Log($"Error on DB: {ex.Message}");
                }
            }
        }
        static bool CheckDomain(string domain)
        {
            //I will add rdap or whois check here in the future
            bool isAvailable = true; // Placeholder for actual availability check
                                     // Log the result
            if (DebugMode)
            {
                LoggingService.Log($"Domain '{domain}' is {(isAvailable ? "available" : "not available")}.");
            }
            SqlResults.AddResults(domain, isAvailable);
            return true; // Change this after try rdap or whois check
        }
    }
}
