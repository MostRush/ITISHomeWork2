using System;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

namespace ExcelParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextReader reader = new StreamReader("sample.csv"))
            {
                var config = new CsvConfiguration(new System.Globalization.CultureInfo("ru-ru"));
                var csvReader = new CsvReader(reader, config);

                var records = csvReader.GetRecords<Product>();

                records.
            }
        }
    }
}
