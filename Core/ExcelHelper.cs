using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using ExcelDataReader;

namespace Core
{
    public static class ExcelHelper
    {
        public static List<int> GetDataFormFile(string fileName)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            var stream = File.Open($"C:\\Users\\Daria_Ivanova2\\source\\repos\\EpamCdpTask1\\Core\\DataProvider\\{fileName}", FileMode.Open, FileAccess.Read);
            var excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            var conf = new ExcelDataSetConfiguration
            {
                ConfigureDataTable = _ => new ExcelDataTableConfiguration
                {
                    UseHeaderRow = true
                }
            };
            var dataSet = excelReader.AsDataSet(conf);
            List<int> numbers = new List<int>();
            //List<DataRow> list = dataSet.Tables[0].Rows.Cast<DataRow>().ToList();
            for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                for (var j = 0; j < dataSet.Tables[0].Rows.Count; j++)
            {
                    numbers.Add(int.Parse(dataSet.Tables[0].Rows[i][j].ToString()));
            }

            //{
                //    _sum += int.Parse(_data.Rows[i][j].ToString());
                //}
            return numbers;

        }
    }
}
