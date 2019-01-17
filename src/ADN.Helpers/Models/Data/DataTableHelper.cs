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
        public class TableCssClasses
        {
            public string[] Table { get; set; } = new string[0];
            public string[] Tr { get; set; } = new string[0];
            public string[] Th { get; set; } = new string[0];
            public string[] Td { get; set; } = new string[0];
        }

        /// <summary>
        /// Convert a DataTable to the equivalent HTML table.
        /// </summary>
        /// <param name="dataTable">DataTable to convert.</param>
        /// <param name="tableCssClasses">Optional parameter. CSS classes.</param>
        /// <returns>HTML table.</returns>
        /// <example>
        /// <code lang="csharp">
        /// DataTable table = new DataTable(new DataTableHelper.TableCssClasses()
        /// {
        ///     Table = new string[] { "c-table" },
        ///     Tr = new string[] { "c-tr-1", "c-tr-2" },
        ///     Th = new string[] { "c-th" },
        ///     Td = new string[] { "c-td" },
        /// });
        /// // populate table
        /// var result = table.ToHtmlTable();
        /// </code>
        /// </example>
        public static string ToHtmlTable(this DataTable dataTable, TableCssClasses tableCssClasses = null)
        {
            string tableCss = string.Empty;
            string trCss = string.Empty;
            string thCss = string.Empty;
            string tdCss = string.Empty;

            if (tableCssClasses != null)
            {
                tableCss = (tableCssClasses.Table.Length > 0) ? $" class='{string.Join(" ", tableCssClasses.Table)}'" : "";
                trCss = (tableCssClasses.Tr.Length > 0) ? $" class='{string.Join(" ", tableCssClasses.Tr)}'" : "";
                thCss = (tableCssClasses.Th.Length > 0) ? $" class='{string.Join(" ", tableCssClasses.Th)}'" : "";
                tdCss = (tableCssClasses.Td.Length > 0) ? $" class='{string.Join(" ", tableCssClasses.Td)}'" : "";
            }

            int numColumns = dataTable.Columns.Count;
            string html = $"<table{tableCss}>";

            // header
            html += "<thead>";
            if (numColumns > 0)
            {
                html += $"<tr{trCss}>";
                for (int i = 0; i < numColumns; i++)
                {
                    html += $"<th{thCss}>{dataTable.Columns[i].ColumnName}</th>";
                }
                html += "</tr>";
            }
            html += "</thead>";

            // rows
            html += "<tbody>";
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                html += $"<tr{trCss}>";
                for (var j = 0; j < numColumns; j++)
                {
                    html += $"<td{tdCss}>{dataTable.Rows[i][j]}</td>";
                }

                html += "</tr>";
            }
            html += "</tbody>";
            html += "</table>";
            return html.ToString();
        }
    }
}
