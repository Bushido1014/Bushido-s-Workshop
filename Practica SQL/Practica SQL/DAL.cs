using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_SQL
{
    class DAL
    {
        string server;
        string database;
        string stringConnection;
        SqlConnection connection;

        public DAL(string server, string database)
        {
            stringConnection = 
                "server= " + server + "; database= " + database + "; integrated security= true";

            connection = new SqlConnection(stringConnection);

            if (databaseExists() == false)
                createDatabase();
        }
        void executeNonQuery(string command)
        {
            SqlCommand sqlCommand = new SqlCommand(command, connection);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }
        bool databaseExists()
        {
            try
            {
                connection.Open();
                connection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        bool tableExists(string table)
        {
            try
            {
                //check

                return true;
            }
            catch
            {
                return false;
            }
        }
        void createDatabase()
        {
            executeNonQuery("create database " + database);
        }
        void createTable(string table)
        {
            executeNonQuery("create table " + table);
        }
        public void query_Insert(string table, string[] columns, string[] values)
        {
            if (tableExists(table) == false)
                createTable(table);

            string query = "Insert into " + table;

            query += " (";

            for(int cic = 0; cic < columns.Length; cic++)
            {
                if (cic == 0)
                    query += "[" + columns[cic] + "]";
                else
                {
                    query += ",";
                    query += "[" + columns[cic] + "]";
                }
                
            }

            query += ") ";

            query += "values";

            query += " (";

            for (int cic = 0; cic < values.Length; cic++)
            {
                if (cic == 0)
                    query += "'" + values[cic] + "'";
                else
                {
                    query += ",";
                    query += "'" + values[cic] + "'";
                }   
            }
                
            query += ")";

            executeNonQuery(query);
        }
        public void query_Delete(string table)
        {
            if (tableExists(table) == false)
                createTable(table);

            executeNonQuery("Delete from " + table);
        }
        public void query_Delete(string table, string column, string value)
        {
            if (tableExists(table) == false)
                createTable(table);

            executeNonQuery("Delete from " + table + " where " + column + " = '" + value + "'");
        }
        public DataTable query_Select(string table)
        {
            if (tableExists(table) == false)
                createTable(table);

            return fillToTable("Select * from " + table);
        }
        public DataTable query_Select(string table, string column, string value)
        {
            if (tableExists(table) == false)
                createTable(table);

            return fillToTable("Select * from " + table + " where " + column + " = '" + value + "'");
        }
        DataTable fillToTable(string selection)
        {
            SqlCommand objCommand = new SqlCommand(selection, connection);
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objCommand);

            DataTable dataTable = new DataTable();
            objDataAdapter.Fill(dataTable);

            return dataTable;
        }
    }
}
