using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MyPCAN_USB
{
    class DataBaseOperation
    {
      
        SqlConnection mycon;
        string table_name = "CarSystem";
        public DataBaseOperation()
        {
            mycon = getcon();
            mycon.Open();
        }
        /// <summary>
        /// 建立数据库连接
        /// </summary>
        /// <returns>返回sqlConnection 对象</returns>
        public SqlConnection getcon()
        {
            string M_str_sqlcon = @"server=localhost\SQLEXPRESS;database=myData;integrated security=true;";
            SqlConnection mycon = new SqlConnection(M_str_sqlcon);
           
            return mycon;
        }

        /// <summary>
        /// 执行sqlCommand 命令
        /// </summary>
        /// <param name="M_str_sqlstr">SQL语句</param>
        public void getcom(string M_str_sqlstr)
        {
            SqlCommand sqlcom = new SqlCommand(M_str_sqlstr, mycon);
            sqlcom.ExecuteNonQuery();
            ////关闭
            //sqlcom.Dispose();
            //sqlcon.Close();
            //sqlcon.Dispose();
        }
        public void getcomPara(string myname, string mysex, int myage, string myschool, string myprovince)
        {
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandText = "INSERT INTO "+table_name+"(Id,name,sex,age,school,province)VALUES(@Id,@name,@sex,@age,@school,@province)";
            sqlcom.Connection = mycon;
            sqlcom.Parameters.Add("@Id", SqlDbType.NChar, 50).Value = DateTime.Now.ToShortTimeString();
            sqlcom.Parameters.Add("@name", SqlDbType.NChar, 50).Value = myname;
            sqlcom.Parameters.Add("@sex", SqlDbType.NChar, 10).Value = mysex;
            sqlcom.Parameters.Add("@age", SqlDbType.Int, 4).Value = myage;
            sqlcom.Parameters.Add("@school", SqlDbType.NChar, 10).Value = myschool;
            sqlcom.Parameters.Add("@province", SqlDbType.NChar, 10).Value = myprovince;

            sqlcom.ExecuteNonQuery();
        }

        public void getcomPara(byte[] data)
        {
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.Connection = mycon;
            try
            {
                sqlcom.CommandText = "INSERT INTO CarSystem(time,name,sex,age,school,province)VALUES(@time,@name,@sex,@age,@school,@province)";

                sqlcom.Parameters.Add("@time", SqlDbType.NChar, 50).Value = DateTime.Now.ToLongTimeString();
                sqlcom.Parameters.Add("@name", SqlDbType.NChar, 50).Value = data[0].ToString("X2");
                sqlcom.Parameters.Add("@sex", SqlDbType.NChar, 10).Value = data[8].ToString("X2");
                sqlcom.Parameters.Add("@age", SqlDbType.Int, 4).Value = Convert.ToInt32(data[16].ToString(), 10);
                sqlcom.Parameters.Add("@school", SqlDbType.NChar, 10).Value = data[24].ToString("X2");
                sqlcom.Parameters.Add("@province", SqlDbType.NChar, 10).Value = data[25].ToString("X2");
                sqlcom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex .ToString ());
            }
        }
        /// <summary>
        /// 开启事务处理
        /// </summary>
        /// <param name="data"></param>
        public void getcomPara(List<byte[]> ReceiveListAnother)
        {
            //开启事务
            SqlTransaction sqltransac = mycon.BeginTransaction();

            //将事务应用于Command
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.Connection = mycon;
            sqlcom.Transaction = sqltransac;

            foreach (byte[] data in ReceiveListAnother)
            {

                sqlcom.CommandText = "INSERT INTO CarSystem(velc,name,sex,age,school,province)VALUES(@velc,@name,@sex,@age,@school,@province)";

                sqlcom.Parameters.Add("@velc", SqlDbType.NChar, 50).Value = DateTime.Now.ToLongTimeString();
                sqlcom.Parameters.Add("@name", SqlDbType.NChar, 50).Value = data[0].ToString("X2");
                sqlcom.Parameters.Add("@sex", SqlDbType.NChar, 10).Value = data[8].ToString("X2");
                sqlcom.Parameters.Add("@age", SqlDbType.Int, 4).Value = Convert.ToInt32(data[16].ToString(), 10);
                sqlcom.Parameters.Add("@school", SqlDbType.NChar, 10).Value = data[24].ToString("X2");
                sqlcom.Parameters.Add("@province", SqlDbType.NChar, 10).Value = data[25].ToString("X2");
                sqlcom.ExecuteNonQuery();
                sqlcom.Parameters.Clear();
            }
            sqltransac.Commit();
            sqltransac.Dispose();
        }


        /// <summary>
        /// 创建DataSet对象
        /// </summary>
        /// <param name="M_str_sqlstr">SQL语句</param>
        /// <param name="M_str_table">表对象</param>
        /// <returns>返回DataSet对象</returns>
        public DataSet getds(string M_str_sqlstr, string M_str_table)
        {
            SqlConnection sqlcon = this.getcon();
            SqlDataAdapter sqlda = new SqlDataAdapter(M_str_sqlstr, sqlcon);
            DataSet myds = new DataSet();
            sqlda.Fill(myds, M_str_table);
            return myds;
        }

        /// <summary>
        /// 创建一个sqlDataReader对象
        /// </summary>
        /// <param name="M_str_sqlstr">SQL</param>
        /// <returns>返回SqlDataReader对象</returns>
        public SqlDataReader getread(string M_str_sqlstr)
        {
            SqlConnection sqlcon = this.getcon();
            SqlCommand sqlcom = new SqlCommand(M_str_sqlstr, sqlcon);
            sqlcon.Open();
            SqlDataReader sqlread = sqlcom.ExecuteReader(CommandBehavior.CloseConnection);
            return sqlread;
        }
        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        /// <param name="sqlcon"></param>
        public void closeDataBase()
        {
            if (mycon != null)
            {
                mycon.Close();
                mycon.Dispose();
            }
        }
    }
}
