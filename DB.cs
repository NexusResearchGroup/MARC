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

    public SqlDataReader ReadRow(string sql)//Ö´ÐÐÒ»¸ösql²éÑ¯²¢·µ»ØÒ»¸öSqlDataReader¶ÔÏó
    {
        SqlConnection Conn = new SqlConnection(ConnectionString);
        SqlCommand objCommand = new SqlCommand(sql, Conn);
        SqlDataReader objDataReader;
        objDataReader = objCommand.ExecuteReader();
        //Èç¹û¼ÇÂ¼²»Îª¿Õ
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


    public void ExeSql(string sql)//ÓÃÀ´Ö´ÐÐ·Ç²éÑ¯µÄsqlÓï¾ä
    {
        //¶¨ÒåÐÂµÄÊý¾ÝÁ¬½Ó¿Ø¼þ²¢³õÊ¼»¯
        SqlConnection Conn = new SqlConnection(ConnectionString);
        //¶¨Òå²¢³õÊ¼»¯ÃüÁî¶ÔÏó
        SqlCommand objCommand = new SqlCommand(sql, Conn);

        Conn.Close();
        Conn.Open();
        try
        {
            objCommand.ExecuteNonQuery();//Ö´ÐÐÃüÁî
        }
        catch (Exception exp)
        {

        }
        //finally
        {
            Conn.Close();
        }
    }

    public DataTable ReadTable(string sql)//¶ÁÊý¾Ý±í
    {
        DataTable myTable = new DataTable();//´´½¨Ò»¸öÊý¾Ý±í
        SqlConnection Conn = new SqlConnection(ConnectionString);
        Conn.Open();
        SqlDataAdapter myAdapter = new SqlDataAdapter(sql, Conn);//¶¨Òå²¢³õÊ¼»¯Êý¾ÝÊÊÅäÆ÷
        myAdapter.Fill(myTable);//½«Êý¾ÝÊÊÅäÆ÷ÖÐµÄÊý¾ÝÌî³äµ½Êý¾Ý¼¯ÖÐ
        Conn.Close();
        return myTable;
    }

    public DataSet ReadDataSet(string sql)//·µ»ØÒ»¸öDataSet
    {
        DataSet myDataSet = new DataSet();
        SqlConnection Conn = new SqlConnection(ConnectionString);
        Conn.Open();
        SqlDataAdapter myAdapter = new SqlDataAdapter(sql, Conn);//¶¨Òå²¢³õÊ¼»¯Êý¾ÝÊÊÅäÆ÷
        myAdapter.Fill(myDataSet);//½«Êý¾ÝÊÊÅäÆ÷ÖÐµÄÊý¾ÝÌî³äµ½Êý¾Ý¼¯ÖÐ
        Conn.Close();
        return myDataSet;
    }

    public DataSet ReadDataSetPara(string sql, int round)//·µ»ØÒ»¸öDataSet
    {
        DataSet myDataSet = new DataSet();
        SqlConnection Conn = new SqlConnection(ConnectionString);
        Conn.Open();

        SqlDataAdapter myAdapter = new SqlDataAdapter(sql, Conn);//¶¨Òå²¢³õÊ¼»¯Êý¾ÝÊÊÅäÆ÷
        SqlParameter sqlpara = new SqlParameter("@round", round.ToString());

        myAdapter.Fill(myDataSet);//½«Êý¾ÝÊÊÅäÆ÷ÖÐµÄÊý¾ÝÌî³äµ½Êý¾Ý¼¯ÖÐ
        Conn.Close();
        return myDataSet;
    }

    public DataSet GetDataSet(string sql, string tableName)
    {
        DataSet myDataSet = new DataSet();
        SqlConnection Conn = new SqlConnection(ConnectionString);
        Conn.Open();
        SqlDataAdapter myAdapter = new SqlDataAdapter(sql, Conn);//¶¨Òå²¢³õÊ¼»¯Êý¾ÝÊÊÅäÆ÷
        myAdapter.Fill(myDataSet, tableName);//½«Êý¾ÝÊÊÅäÆ÷ÖÐµÄÊý¾ÝÌî³äµ½Êý¾Ý¼¯ÖÐ
        Conn.Close();
        return myDataSet;
    }


}
