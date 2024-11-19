using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterProject.BackEnd
{
    public class ServerRepositorySQLite
    {
        SQLiteConnection connection;
        string ConnectionPath;
        public ServerRepositorySQLite(string connectionPath)
        {
            connection = new SQLiteConnection(@$"Data Source={connectionPath};Version = 3");
            ConnectionPath = connectionPath;
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public string GetConnectionPath()
        {
            return ConnectionPath;
        }

        public SQLiteConnection GetSQLiteConnection()
        {
            return connection;
        }

        public string GetDatabaseName()
        {
            string result = null;

            string[] splitCon = ConnectionPath.Split(@"\");
            string unfilteredName = splitCon[splitCon.Length - 1];
            string[] finalResult = unfilteredName.Split(".");
            result = finalResult[0];

            return result;
        }

        public List<string> GetTableList()
        {
            try
            {
                connection.Open();

                SQLiteCommand getTables = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type = 'table'; ", connection);
                SQLiteDataAdapter myCountAdapter = new SQLiteDataAdapter(getTables);
                DataSet ds = new DataSet();
                myCountAdapter.Fill(ds);

                List<string?> tableList = new List<string?>();
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                tableList = dt.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("name")).ToList();
                connection.Close();
                return tableList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataTable GetData(string tableName)
        {
            try
            {
                DataTable dataTable = new DataTable();

                connection.Open();

                SQLiteDataAdapter sqlDa = new SQLiteDataAdapter($@"select * from [{tableName}]", connection);

                sqlDa.Fill(dataTable);

                connection.Close();

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
    }
}