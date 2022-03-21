using System.Data;
using System.IO;

namespace TestProject1.Utils
{
    public static class LogUtil
    {
        public static void WriteTableToTxtFile(DataTable table,string outputFilePath)
        {
            using (var writer = new StreamWriter(outputFilePath))
            {
                for (var i = 0; i < table.Rows.Count; i++)
                {
                    for (var j = 0; j < table.Columns.Count; j++)
                    {
                        writer.Write(table.Rows[i][j]+"||");
                    }
                    writer.WriteLine();
                }   
            }
        }
    }
}