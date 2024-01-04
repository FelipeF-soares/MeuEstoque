using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuEstoque.DataBase;

public class LocalDB
{
    public string stringConn;
    public SqlConnection connDB;
    public LocalDB()
    {
        try
        {
            stringConn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\github\\MeuEstoque\\MeuEstoque\\DataBase\\Database1.mdf;Integrated Security=True";
            connDB = new SqlConnection(stringConn);
            connDB.Open();
        }
        catch(Exception ex) 
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void SqlCommand(string sql)
    {
        try
        {
            SqlCommand sqlCommand = new SqlCommand(sql, connDB);
            sqlCommand.CommandTimeout = 0;
            sqlCommand.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            connDB.Close();
        }
    }

    public DataTable SqlQuery(string sql) 
    {
        DataTable dataTable = new DataTable();
        try
        {
            SqlCommand sqlCommand = new SqlCommand(sql, connDB);
            sqlCommand.CommandTimeout = 0;
            var myReader = sqlCommand.ExecuteReader();
            dataTable.Load(myReader);
            return dataTable;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);

        }
        finally
        {
            connDB.Close();
        }
        
    }
}
