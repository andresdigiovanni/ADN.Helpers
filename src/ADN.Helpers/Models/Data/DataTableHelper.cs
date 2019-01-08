using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ADN.Helpers.Data
{
    /// <summary>
    /// A static class of extension methods for <see cref="DataTable"/>.
    /// </summary>
    public static class DataTableHelper
    {
        /// <summary>
        /// Convert a DataTable to the equivalent HTML table.
        /// </summary>
        /// <param name="dataTable">DataTable to convert.</param>
        /// <returns>HTML table.</returns>
        /// <example>
        /// <code lang="csharp">
        /// DataTable table = new DataTable();
        /// // populate table
        /// var result = table.ToHtmlTable();
        /// </code>
        /// </example>
        public static string ToHtmlTable(this DataTable dataTable)
        {
            int numColumns = dataTable.Columns.Count;
            string html = "<table>";

            // header
            html += "<thead>";
            if (numColumns > 0)
            {
                html += "<tr>";
                for (int i = 0; i < numColumns; i++)
                {
                    html += $"<th>{dataTable.Columns[i].ColumnName}</th>";
                }
                html += "</tr>";
            }
            html += "</thead>";

            // rows
            html += "<tbody>";
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                html += "<tr>";
                for (var j = 0; j < numColumns; j++)
                {
                    html += $"<td>{dataTable.Rows[i][j]}</td>";
                }

                html += "</tr>";
            }
            html += "</tbody>";
            html += "</table>";
            return html.ToString();
        }
    }
}
