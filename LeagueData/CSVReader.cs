using System.Globalization;
using CsvHelper;
using LeagueData.Entities;

namespace LeagueData;

public static class CSVReader
{
    private const string CSVPath = "/Users/matias/Downloads/OracleElixer/all_data.csv";

    public static List<OeEntity> ReadInCSV()
    {
        using (var reader = new StreamReader(CSVPath))
        {
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return csv.GetRecords<OeEntity>().ToList();
            }
        }
    }
}