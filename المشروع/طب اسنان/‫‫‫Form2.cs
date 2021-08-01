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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
			
			getAllRecords();
			
			getAllRecords2();
		
			rest_data();
			
		}
		
		
		void  rest_data()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			comboBox2.SelectedIndex = 0;
			comboBox1.SelectedIndex = 0;
		}
	
	
		public void getAllRecords()
		{
			dataGridView1.Rows.Clear();
			
			OleDbConnection con = DataBase.createConnection();

			String selectSQL = "SELECT * FROM dates order by date_id desc";

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();

			while (reader.Read()) {
				
				dataGridView1.Rows.Add(new string[] {
					reader["date_id"].ToString(),
					reader["date_day"].ToString(),
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
		
		public void getAllRecords2()
		{
			
			OleDbConnection con = DataBase.createConnection();

			String selectSQL = "SELECT * FROM patients order by patient_id desc";

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();

			comboBox2.DisplayMember = "Text";
			
			comboBox2.ValueMember = "Value";
			
			while (reader.Read()) {
				
				comboBox2.Items.Add(new { Text = reader["patient_name"].ToString(), Value = reader["patient_id"].ToString() });
				
			}

			reader.Close();

			con.Close();
			
			if (comboBox2.Items.Count == 0) {
				MessageBox.Show("لايوجد مرضى بعد");
				
				Close();
			
			}
		}
		
		public void delete(string id)
		{
			OleDbConnection con = DataBase.createConnection();
			
			String insertSQL = "DELETE FROM dates where date_id=" + id;

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
				comboBox1.SelectedItem = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
				textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
				textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
				for (int i = 0; i < comboBox2.Items.Count; i++) {
					string hh = (comboBox2.Items[i] as dynamic).Value;
					if (hh.Equals(dataGridView1.SelectedRows[0].Cells[5].Value.ToString())) {
						comboBox2.SelectedIndex = i;
						break;
					}
				
				}
				
			}
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]")) {
				textBox2.Text = "";
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			if (!textBox1.Text.Trim().Equals("") && !textBox2.Text.Trim().Equals("")) {

					
				OleDbConnection con = DataBase.createConnection();

				String insertSQL = "update dates set date_day='" + comboBox1.SelectedItem + "' , date_time_from='" + textBox1.Text + "', date_time_to='" + textBox2.Text + "',date_patient_id=" + (comboBox2.SelectedItem as dynamic).Value + " where date_id =" + dataGridView1.SelectedRows[0].Cells[0].Value;

				OleDbCommand command = new OleDbCommand(insertSQL, con);

				command.ExecuteNonQuery();

				con.Close();
				
				getAllRecords();
 				
				rest_data();
			
			} 
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0) { 
			
				delete(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
			
				getAllRecords();

			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			rest_data();
			;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (!textBox1.Text.Trim().Equals("") && !textBox2.Text.Trim().Equals("")) {
			
				OleDbConnection con = DataBase.createConnection();

				String insertSQL = "insert into dates (date_patient_id,date_day,date_time_from,date_time_to) values (" + (comboBox2.SelectedItem as dynamic).Value + ",'" + comboBox1.SelectedItem + "','" + textBox1.Text + "','" + textBox2.Text + "')";

				OleDbCommand command = new OleDbCommand(insertSQL, con);

				command.ExecuteNonQuery();

				con.Close();
			
				getAllRecords();
				
				rest_data();
				
			} else {
				MessageBox.Show("الرجاء التأكد من المدخلات");
			}
		}
		
		
	

	}
}