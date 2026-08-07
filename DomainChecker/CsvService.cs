using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainChecker
{
    // I will use CsvHelper to write the Csv files.
    // I think i need to use "using()" on CsvHelper to use any of the CsvHelper methods.

    //It's can be a bug on multi threading, but I will use it for now.
    internal class CsvService
    {
        static string CsvPath = ConfigurationManager.AppSettings["CsvPath"];
        static bool fileExists = File.Exists(CsvPath);

        static public void ClearCsv()
        {
            if (File.Exists(CsvPath))
            {
                File.Delete(CsvPath);
                fileExists = false;
            }
        }
        static public void MoveCsv(string newPath)
        {
            if (File.Exists(CsvPath))
            {
                var dir = Path.GetDirectoryName(newPath);
                if (!string.IsNullOrEmpty(dir))
                    Directory.CreateDirectory(dir);
                File.Move(CsvPath, newPath);
            }
        }
        static void CreateCsv()
        {
            if (fileExists) return;

            var dir = Path.GetDirectoryName(CsvPath);
            if (!string.IsNullOrEmpty(dir))
                Directory.CreateDirectory(dir);

            using (var stream = new FileStream(CsvPath, FileMode.Create, FileAccess.Write, FileShare.Read))
            using (var writer = new StreamWriter(stream, new UTF8Encoding(false)))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteHeader<Foo>();
                csv.NextRecord();
            }
            fileExists = true;
        }


        static public void AddCsv(string name, bool status)
        {
            CreateCsv();

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = !fileExists
            };

            using (var stream = new FileStream(CsvPath, FileMode.Append, FileAccess.Write, FileShare.Read))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, config))
            {
                var record = new Foo { Name = name, Status = status };

                if (!fileExists)
                {
                    csv.WriteHeader<Foo>();
                    csv.NextRecord();
                }

                csv.WriteRecord(record);
                csv.NextRecord();
            }
        }
    }

    public class Foo
    {
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}