using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace طب_اسنان
{
	public partial class Form8 : Form
	{
		public Form8()
		{
			InitializeComponent();

			getAllRecords();
		
		}
        
        
		public void getAllRecords()
		{
			dataGridView2.Rows.Clear();
			
			OleDbConnection con = DataBase.createConnection();

			String selectSQL = "SELECT * FROM patients order by patient_id desc";

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();

			while (reader.Read()) {
				
				dataGridView2.Rows.Add(new string[] {
					reader["patient_id"].ToString(),
					reader["patient_name"].ToString(),
					reader["patient_father_name"].ToString(),
					reader["patient_mother_name"].ToString(),
					reader["patient_age"].ToString(),
					reader["patient_married"].ToString()
						
				});

			}

			reader.Close();

			con.Close();
			
			textBox4.Text = "";
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (!textBox1.Text.Trim().Equals("") && !textBox2.Text.Trim().Equals("") && !textBox3.Text.Trim().Equals("")) {
			
				OleDbConnection con = DataBase.createConnection();

				String insertSQL = "insert into sessions (sessions_patient_id,sessions_date,sessions_time_from,sessions_time_to,sessions_notes) values (" + dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + ",'" + dateTimePicker1.Value.ToShortDateString() + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";

				OleDbCommand command = new OleDbCommand(insertSQL, con);

				command.ExecuteNonQuery();

				con.Close();
			
				getRecordsSessions();
				
				rest_data();
			} else {
				MessageBox.Show("الرجاء التأكد من المدخلات");
			}
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(textBox4.Text)) {
			
				OleDbConnection con = DataBase.createConnection();

				String insertSQL = "update sessions set sessions_patient_id='" + dataGridView2.SelectedRows[0].Cells[0].Value + "' , sessions_date='" + dateTimePicker1.Value.ToShortDateString() + "', sessions_time_from='" + textBox1.Text + "', sessions_time_to='" + textBox2.Text + "', sessions_notes='" + textBox3.Text + "' where sessions_id =" + dataGridView1.SelectedRows[0].Cells[0].Value;

				OleDbCommand command = new OleDbCommand(insertSQL, con);

				command.ExecuteNonQuery();

				con.Close();
				
				getRecordsSessions();
 				
				rest_data();
			}
			
		}
		
		void  rest_data()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
		}
	
		void DataGridView2SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridView2.SelectedRows.Count > 0) {  
			
				getRecordsSessions();
			
			}
		}
		
		public void getRecordsSessions()
		{
		
			dataGridView1.Rows.Clear();


			OleDbConnection con = DataBase.createConnection();

			String selectSQL = "SELECT * FROM sessions where sessions_patient_id = " + dataGridView2.SelectedRows[0].Cells[0].Value + " order by sessions_id desc";

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();
			
			while (reader.Read()) {
				
				dataGridView1.Rows.Add(new string[] {
					reader["sessions_id"].ToString(),
					DateTime.Parse(reader["sessions_date"].ToString()).ToString("dd/MM/yyyy"),
					reader["sessions_time_from"].ToString(),
					reader["sessions_time_to"].ToString(),
					reader["sessions_notes"].ToString()
				                       		
				});

			}

			reader.Close();

			con.Close();

		
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			rest_data();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0) { 
			
				delete(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
				
				getRecordsSessions();
				
				rest_data();
			
			}
				

		}
		
	
		
		public void delete(string id)
		{
			OleDbConnection con = DataBase.createConnection();
			
			String insertSQL = "DELETE FROM sessions where sessions_id=" + id;

			OleDbCommand command = new OleDbCommand(insertSQL, con);

			command.ExecuteNonQuery();

			con.Close();
		
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]")) {
				textBox1.Text = "";
			}
		}
	
		void DataGridView1MouseClick(object sender, MouseEventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0) {  
				textBox4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
				dateTimePicker1.Value = DateTime.ParseExact(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), "dd/MM/yyyy",
					CultureInfo.InvariantCulture);
				textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
				textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
				textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
			}
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]")) {
				textBox2.Text = "";
			}
		}
		
		
	

	}
}