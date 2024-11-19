using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterProject.BackEnd.SQL
{
    public class ServerRepositorySql
    {
        public string connString = null;
        private SqlConnection conn = null;
        string DatabaseName = null;
        public ServerRepositorySql(string serverName,string userName, string password)
        {
            connString = @"Server=" + serverName + @";User ID=" + userName + @";Password=" + password;
            conn = new SqlConnection(connString);
        }

        public SqlConnection GetConnection()
        {
            return conn;
        }

        public bool GetServerStatus()
        {
            bool status = false;
            try
            {
                conn.Open();
                status = true;
                conn.Close();
                return status;
            }
            catch (SqlException)
            {
                return status;
            }
        }

        public List<string> GetDatabaseList()
        {
            try
            {
                string command = @"SELECT name FROM master.sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb');";
                List<string?> databaseList = new List<string?>();
                DataTable dt = new DataTable();

                conn.Open();
                SqlCommand cmd = new SqlCommand(command, conn);
                dt.Load(cmd.ExecuteReader());
                conn.Close();

                databaseList = dt.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("name")).ToList();

                return databaseList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public List<string> GetTableList(string databaseName)
        {
            try
            {
                string command = $@"use {databaseName}; SELECT table_name FROM information_schema.tables WHERE table_type = 'base table' and table_name NOT IN ('sysdiagrams');";
                List<string?> tableList = new List<string?>();
                DataTable dt = new DataTable();

                conn.Open();
                SqlCommand cmd = new SqlCommand(command, conn);
                dt.Load(cmd.ExecuteReader());
                tableList = dt.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("table_name")).ToList();
                conn.Close();

                DatabaseName = databaseName;

                return tableList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public DataTable GetData(string tableName)
        {
            try
            {
                DataTable dataTable = new DataTable();

                conn.Open();

                SqlDataAdapter sqlDa = new SqlDataAdapter($@"use {DatabaseName} select * from [{tableName}]", conn);

                sqlDa.Fill(dataTable);

                conn.Close();

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public DataTable GetData(string databaseName, string tableName)
        {
            try
            {
                DataTable dataTable = new DataTable();

                conn.Open();

                SqlDataAdapter sqlDa = new SqlDataAdapter($@"use {databaseName} select * from [{tableName}]", conn);

                sqlDa.Fill(dataTable);

                conn.Close();

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public string GetConnectionString()
        {
            return connString;
        }

        public void CloseConnection()
        {
            conn.Close();
        }
    }
}
