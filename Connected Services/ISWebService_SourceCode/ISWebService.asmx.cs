using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ISWebService
{
    /// <summary>
    /// Summary description for ISWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ISWebService : System.Web.Services.WebService
    {
        string connStr = DBHelper.Getconnectionstring("ISDB");

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int CountByManufacturer(string _manufacturer)
        {
            return this.CountByColumnValue("Manufacturer", _manufacturer);
        }

        [WebMethod]
        public int CountByResolution(string _resolution)
        {
            return this.CountByColumnValue("Resolution", _resolution);
        }

        [WebMethod]
        public List<String> GetResolutions()
        {
            return this.GetUniqueValues("Resolution");
        }

        [WebMethod]
        public List<String> GetColumnNames()
        {
            return this.GetColumns();
        }

        [WebMethod]
        public void ExportToXML(string[] _columns, string _fileName)
        {
            this.ExportToXMLFile(_columns, _fileName);
        }

        private int CountByColumnValue(string _columnName, string _value)
        {
            int ret = 0;
            string sql;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                sql = $"select count(*) from Laptop where {_columnName} = @colValue";

                using (var command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@colValue", _value);

                    ret = (Int32)command.ExecuteScalar();
                }
            }

            return ret;
        }

        private List<String> GetUniqueValues(string _columnName)
        {
            string sql;
            List<String> columnData = new List<String>();

            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();

                sql = $"SELECT DISTINCT {_columnName} FROM Laptop";

                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            columnData.Add(reader.GetString(0));
                        }
                    }
                }
            }

            return columnData;
        }

        public List<String> GetColumns()
        {
            string       sql;
            List<string> columns = new List<string>();

            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();

                sql = "select c.name from sys.columns c inner join sys.tables t on t.object_id = c.object_id and t.name = 'Laptop' and t.type = 'U'";

                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            columns.Add(reader.GetString(0));
                        }
                    }
                }
            }

            return columns;
        }

        private void ExportToXMLFile(string[] _columns, string _fileName)
        {
            string       sql;
            DataTable    dataTable;
            DataColumn[] stringColumns;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();

                sql = $"SELECT {string.Join(",", _columns)} FROM Laptop";

                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    dataTable = new DataTable("Laptop");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);

                        stringColumns = 
                            dataTable.Columns.Cast<DataColumn>()
                           .Where(c => c.DataType == typeof(string))
                           .ToArray();

                        foreach (DataRow row in dataTable.Rows)
                        {
                            foreach (DataColumn col in stringColumns)
                            {
                                row.SetField<string>(col, row.Field<string>(col).Trim());
                            }
                        }

                        dataTable.WriteXml(_fileName);
                    }
                }
            }
        }
    }
}
