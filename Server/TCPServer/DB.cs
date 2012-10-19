using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

public class DB
{
    string ConnectionString;
    public DB(string str)
    {
        ConnectionString = str;
        //"Data Source=128.101.111.9;Initial Catalog=SmartSignalDB;Integrated Security=no;UID=henry;Password=liugroup";
    }

    public SqlDataReader ReadRow(string sql)//执行一个sql查询并返回一个SqlDataReader对象
    {
        SqlConnection Conn = new SqlConnection(ConnectionString);
        SqlCommand objCommand = new SqlCommand(sql, Conn);
        SqlDataReader objDataReader;
        objDataReader = objCommand.ExecuteReader();
        //如果记录不为空
        if (objDataReader.Read())
        {
            objCommand.Dispose();
            return objDataReader;
        }
        else
        {
            objCommand.Dispose();
            return null;
        }
    }


    public void ExeSql(string sql)//用来执行非查询的sql语句
    {
        //定义新的数据连接控件并初始化
        SqlConnection Conn = new SqlConnection(ConnectionString);
        //定义并初始化命令对象
        SqlCommand objCommand = new SqlCommand(sql, Conn);
        
        Conn.Close();
        Conn.Open();
        try
        {
            objCommand.ExecuteNonQuery();//执行命令
        }
        catch (Exception exp)
        {

        }
        //finally
        {
            Conn.Close();
        }
    }

    public DataTable ReadTable(string sql)//读数据表
    {
        DataTable myTable = new DataTable();//创建一个数据表
        SqlConnection Conn = new SqlConnection(ConnectionString);
        Conn.Open();
        SqlDataAdapter myAdapter = new SqlDataAdapter(sql, Conn);//定义并初始化数据适配器
        myAdapter.Fill(myTable);//将数据适配器中的数据填充到数据集中
        Conn.Close();
        return myTable;
    }

    public DataSet ReadDataSet(string sql)//返回一个DataSet
    {
        DataSet myDataSet = new DataSet();
        SqlConnection Conn = new SqlConnection(ConnectionString);
        Conn.Open();
        SqlDataAdapter myAdapter = new SqlDataAdapter(sql, Conn);//定义并初始化数据适配器
        myAdapter.Fill(myDataSet);//将数据适配器中的数据填充到数据集中
        Conn.Close();
        return myDataSet;
    }

    public DataSet ReadDataSetPara(string sql, int round)//返回一个DataSet
    {
        DataSet myDataSet = new DataSet();
        SqlConnection Conn = new SqlConnection(ConnectionString);
        Conn.Open();
        
        SqlDataAdapter myAdapter = new SqlDataAdapter(sql, Conn);//定义并初始化数据适配器
        SqlParameter sqlpara = new SqlParameter("@round", round.ToString());

        myAdapter.Fill(myDataSet);//将数据适配器中的数据填充到数据集中
        Conn.Close();
        return myDataSet;
    }

    public DataSet GetDataSet(string sql, string tableName)
    {
        DataSet myDataSet = new DataSet();
        SqlConnection Conn = new SqlConnection(ConnectionString);
        Conn.Open();
        SqlDataAdapter myAdapter = new SqlDataAdapter(sql, Conn);//定义并初始化数据适配器
        myAdapter.Fill(myDataSet, tableName);//将数据适配器中的数据填充到数据集中
        Conn.Close();
        return myDataSet;
    }


}
