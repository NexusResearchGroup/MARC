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

    public SqlDataReader ReadRow(string sql)//ִ��һ��sql��ѯ������һ��SqlDataReader����
    {
        SqlConnection Conn = new SqlConnection(ConnectionString);
        SqlCommand objCommand = new SqlCommand(sql, Conn);
        SqlDataReader objDataReader;
        objDataReader = objCommand.ExecuteReader();
        //�����¼��Ϊ��
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


    public void ExeSql(string sql)//����ִ�зǲ�ѯ��sql���
    {
        //�����µ��������ӿؼ�����ʼ��
        SqlConnection Conn = new SqlConnection(ConnectionString);
        //���岢��ʼ���������
        SqlCommand objCommand = new SqlCommand(sql, Conn);
        
        Conn.Close();
        Conn.Open();
        try
        {
            objCommand.ExecuteNonQuery();//ִ������
        }
        catch (Exception exp)
        {

        }
        //finally
        {
            Conn.Close();
        }
    }

    public DataTable ReadTable(string sql)//�����ݱ�
    {
        DataTable myTable = new DataTable();//����һ�����ݱ�
        SqlConnection Conn = new SqlConnection(ConnectionString);
        Conn.Open();
        SqlDataAdapter myAdapter = new SqlDataAdapter(sql, Conn);//���岢��ʼ������������
        myAdapter.Fill(myTable);//�������������е�������䵽���ݼ���
        Conn.Close();
        return myTable;
    }

    public DataSet ReadDataSet(string sql)//����һ��DataSet
    {
        DataSet myDataSet = new DataSet();
        SqlConnection Conn = new SqlConnection(ConnectionString);
        Conn.Open();
        SqlDataAdapter myAdapter = new SqlDataAdapter(sql, Conn);//���岢��ʼ������������
        myAdapter.Fill(myDataSet);//�������������е�������䵽���ݼ���
        Conn.Close();
        return myDataSet;
    }

    public DataSet ReadDataSetPara(string sql, int round)//����һ��DataSet
    {
        DataSet myDataSet = new DataSet();
        SqlConnection Conn = new SqlConnection(ConnectionString);
        Conn.Open();
        
        SqlDataAdapter myAdapter = new SqlDataAdapter(sql, Conn);//���岢��ʼ������������
        SqlParameter sqlpara = new SqlParameter("@round", round.ToString());

        myAdapter.Fill(myDataSet);//�������������е�������䵽���ݼ���
        Conn.Close();
        return myDataSet;
    }

    public DataSet GetDataSet(string sql, string tableName)
    {
        DataSet myDataSet = new DataSet();
        SqlConnection Conn = new SqlConnection(ConnectionString);
        Conn.Open();
        SqlDataAdapter myAdapter = new SqlDataAdapter(sql, Conn);//���岢��ʼ������������
        myAdapter.Fill(myDataSet, tableName);//�������������е�������䵽���ݼ���
        Conn.Close();
        return myDataSet;
    }


}
