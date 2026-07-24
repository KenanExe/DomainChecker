using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DomainChecker.Form1;

namespace DomainChecker
{
    internal class CheckingService
    {
        static bool DebugMode = ConfigurationManager.AppSettings["DebugMode"] == "true";
        // To Do: Make a loop for checking all items in the queue and add a delay between each check
        public static async Task<bool> StartCheckingLoopAsync(int time)
        {
            while (true)
            {
                bool result = await StartCheckingAsync();
                if (!result)
                {
                    break;
                }
                await Task.Delay(time); // I still learning async/await
            }
            return true;
        }

        public static async Task<bool> StartCheckingAsync()
        {
            string dbPath = ConfigurationManager.AppSettings["DbPath"];
            string connectionString = $"Data Source={dbPath};Version=3;";

            string itemName = null;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    string selectSql = "SELECT Name FROM TblQueue ORDER BY rowid ASC LIMIT 1;";

                    using (SQLiteCommand selectCmd = new SQLiteCommand(selectSql, connection))
                    using (SQLiteDataReader reader = (SQLiteDataReader)await selectCmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            itemName = reader["Name"].ToString();
                        }
                        else
                        {
                            return false;
                        }
                    }

                    int isSuccess = await CheckDomainAsync(itemName);

                    if (isSuccess == 200)
                    {
                        SqlResults.AddResults(itemName, false);

                        string deleteSql = "DELETE FROM TblQueue WHERE Name = @Name;";
                        using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteSql, connection))
                        {
                            deleteCmd.Parameters.AddWithValue("@Name", itemName);
                            await deleteCmd.ExecuteNonQueryAsync();
                            return true;
                        }
                    }
                    else if (isSuccess == 404)
                    {
                        SqlResults.AddResults(itemName, true);
                        string deleteSql = "DELETE FROM TblQueue WHERE Name = @Name;";
                        using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteSql, connection))
                        {
                            deleteCmd.Parameters.AddWithValue("@Name", itemName);
                            await deleteCmd.ExecuteNonQueryAsync();
                            return true;
                        }
                    }
                    else
                    {
                        LoggingService.Log($"{itemName} html status code:{isSuccess} Error on checking domain.\n Maybe problem is rate limit\n Try speed down on checking speed");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    LoggingService.Log($"Error on DB: {ex.Message}");
                    return false;
                }
            }
        }

        static async Task<int> CheckDomainAsync(string domain)
        {
            //I will add rdap or whois check here in the future
            return await RdapChecker.CheckDomainAsync(domain); // Change this after try rdap or whois check
        }
    }
}