using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace طب_اسنان
{
	public class DataBase
	{
		public static OleDbConnection createConnection()
		{

			int index = Application.ExecutablePath.LastIndexOf('\\');

			string path = Application.ExecutablePath.Substring(0, index) + "\\" + "db1.mdb";

			OleDbConnection aConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Jet OLEDB:Database Password=lolo");

			aConnection.Open();

			return aConnection;

		}
		
	}
}