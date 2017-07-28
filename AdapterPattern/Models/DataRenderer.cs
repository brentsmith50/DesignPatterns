using System.Data;
using System.IO;

namespace AdapterPattern.Models
{
    public class DataRenderer
    {
        private IDbDataAdapter dataAdapter;

        public DataRenderer(IDbDataAdapter dataAdapter)
        {
            this.dataAdapter = dataAdapter;
        }

        public void Render(TextWriter writer)
        {
            writer.WriteLine("Rendering Data: ");
            var dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            foreach (DataTable table in dataSet.Tables)
            {
                foreach (DataColumn column in table.Columns)
                {
                    writer.Write(column.ColumnName.PadRight(20) + " ");
                }
                writer.WriteLine();
                foreach (DataRow row in table.Rows)
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        writer.Write(row[i].ToString().PadRight(20) + " ");
                    }
                    writer.WriteLine();
                }
            }
        }
    }
}
