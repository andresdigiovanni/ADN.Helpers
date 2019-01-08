using ADN.Helpers.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Xunit;

namespace ADN.Helpers.Tests.Data
{
    public class DataTableHelperTest
    {
        [Theory]
        [ClassData(typeof(ToHtmlTableData))]
        public void ToHtmlTable(DataTable table, string expected)
        {
            var result = table.ToHtmlTable();

            Assert.Equal(expected, result);
        }

        public class ToHtmlTableData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { CreateDataTable(0, 0), CreateHTML(0, 0) };
                yield return new object[] { CreateDataTable(1, 1), CreateHTML(1, 1) };
                yield return new object[] { CreateDataTable(1, 10), CreateHTML(1, 10) };
                yield return new object[] { CreateDataTable(10, 1), CreateHTML(10, 1) };
                yield return new object[] { CreateDataTable(10, 10), CreateHTML(10, 10) };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        private static DataTable CreateDataTable(int columns, int rows)
        {
            DataTable table = new DataTable();

            for (int i = 0; i < columns; i++)
            {
                DataColumn column = new DataColumn
                {
                    ColumnName = "id" + i.ToString()
                };
                table.Columns.Add(column);
            }

            for (int i = 0; i < rows; i++)
            {
                DataRow row = table.NewRow();
                for (int j = 0; j < columns; j++)
                {
                    row["id" + j.ToString()] = j;
                }

                table.Rows.Add(row);
            }

            return table;
        }

        private static string CreateHTML(int columns, int rows)
        {
            string html = "<table>";

            html += "<thead>";
            if (columns > 0)
            {
                html += "<tr>";
                for (int i = 0; i < columns; i++)
                {
                    html += $"<th>id{i.ToString()}</th>";
                }
                html += "</tr>";
            }
            html += "</thead>";

            html += "<tbody>";
            for (int i = 0; i < rows; i++)
            {
                html += "<tr>";

                for (int j = 0; j < columns; j++)
                {
                    html += $"<td>{j}</td>";
                }

                html += "</tr>";
            }
            html += "</tbody>";
            html += "</table>";

            return html;
        }
    }
}
