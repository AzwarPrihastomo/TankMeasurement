using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace TankMeasurement
{
    class cMySQL
    {
        MySqlConnection Conn = new MySqlConnection();
        public bool Connect(String ConString)
        {
            bool isConnect = false;
            Conn = new MySqlConnection();
            Conn.ConnectionString = ConString;
            try
            {
                Conn.Open();
                isConnect = true;
            }
            catch(MySqlException myerror)
            {
                MessageBox.Show("Error Connecting to Server Database: " + myerror.Message);
                isConnect = false;
            }
            return isConnect;
        }


        public bool DisConnect()
        {
            bool isDisconnect = false;
            try
            {
                Conn.Close();
                isDisconnect = true;
            }
            catch (MySqlException myerror)
            {
                MessageBox.Show("Error disconnecting to Server Database: " + myerror.Message);
                isDisconnect = false;
            }
            return isDisconnect;
        }

        public DataSet GetData(string MyQuery)
        {
            DataSet mydata = new DataSet();
            MySqlDataAdapter myAdapter = new MySqlDataAdapter(MyQuery, Conn);
            myAdapter.Fill(mydata);
            return mydata;
        }

        public bool SetData(string myQuery)
        {
            MySqlCommand myCommand = new MySqlCommand(myQuery);
            bool setDataSuccess = false;
            myCommand.Connection = Conn;
            try
            {
                myCommand.ExecuteNonQuery();
                setDataSuccess = true;
            }
            catch (MySqlException myError)
            {
                MessageBox.Show("Error Connecting to Database: " + myError.Message);
                setDataSuccess = false;
            }
            return setDataSuccess;
        }
        public bool command_sql(MySqlCommand comand_data)
        {
            try
            {
                comand_data.ExecuteNonQuery();
            }
            catch (MySqlException myError)
            {
                MessageBox.Show("Error Connecting to Database: " + myError.Message);
                return false;
            }
            return true;
        }

    }
}
