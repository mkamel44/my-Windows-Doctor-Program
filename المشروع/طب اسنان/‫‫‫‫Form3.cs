using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace طب_اسنان
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
			
		}
		
	
		public void getAllRecords(string ss)
		{
			dataGridView1.Rows.Clear();
			
			OleDbConnection con = DataBase.createConnection();

			String selectSQL = "SELECT * FROM dates where date_day='" + ss + "' order by date_id desc";

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();

			while (reader.Read()) {
				
				dataGridView1.Rows.Add(new string[] {
					reader["date_id"].ToString(),
					reader["date_time_from"].ToString(),
					reader["date_time_to"].ToString(),
					getNameOFPatient(reader["date_patient_id"].ToString()),
					reader["date_patient_id"].ToString(),
						
				});

			}

			reader.Close();

			con.Close();
		}
		
		public string getNameOFPatient(string patient_id)
		{
			string name = "";
			
			OleDbConnection con = DataBase.createConnection();

			String selectSQL = "SELECT * FROM patients where patient_id =" + patient_id;

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();

			if (reader.Read()) {
				
				name =	reader["patient_name"].ToString();
				
			}

			reader.Close();

			con.Close();
			
			return name;

		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0) {
				if (e.ColumnIndex == 5) {
					
					yes();
					
					delete();
					
					getAllRecords(comboBox1.SelectedItem.ToString());		
							
					
				} else if (e.ColumnIndex == 6) {
					
					delete();
					
					getAllRecords(comboBox1.SelectedItem.ToString());		
					
				}
				
					
			}
		}
		
		void yes()
		{
		
			OleDbConnection con = DataBase.createConnection();

			String insertSQL = "insert into sessions (sessions_patient_id,sessions_date,sessions_time_from,sessions_time_to,sessions_notes) values (" + dataGridView1.SelectedRows[0].Cells[4].Value.ToString() + ",'" + DateTime.Now.ToShortDateString() + "','" + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "','" + dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + "','')";

			OleDbCommand command = new OleDbCommand(insertSQL, con);

			command.ExecuteNonQuery();
		
		}
		
	
		
		public void delete()
		{
			OleDbConnection con = DataBase.createConnection();
			
			String insertSQL = "DELETE FROM dates where date_id=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

			OleDbCommand command = new OleDbCommand(insertSQL, con);

			command.ExecuteNonQuery();

			con.Close();
		
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			getAllRecords(((ComboBox)sender).SelectedItem.ToString());		
		}
		
	
	}
}