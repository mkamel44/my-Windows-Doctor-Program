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
	public partial class Form4 : Form
	{
		public Form4()
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
			if (!textBox1.Text.Trim().Equals("") && !textBox2.Text.Trim().Equals("") && !textBox3.Text.Trim().Equals("") && !textBox5.Text.Trim().Equals("") && !textBox6.Text.Trim().Equals("")) {
			
				OleDbConnection con = DataBase.createConnection();

				String insertSQL = "insert into patients (patient_name,patient_father_name,patient_mother_name,patient_age,patient_married) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";

				OleDbCommand command = new OleDbCommand(insertSQL, con);

				command.ExecuteNonQuery();

				con.Close();
			
				getAllRecords();
				
				rest_data();
			} else {
				MessageBox.Show("الرجاء التأكد من المدخلات");
			}
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(textBox4.Text)) {
			
				OleDbConnection con = DataBase.createConnection();

				String insertSQL = "update patients set patient_name='" + textBox1.Text + "' , patient_father_name='" + textBox2.Text + "', patient_mother_name='" + textBox3.Text + "', patient_age='" + textBox5.Text + "', patient_married='" + textBox6.Text + "' where patient_id =" + textBox4.Text;

				OleDbCommand command = new OleDbCommand(insertSQL, con);

				command.ExecuteNonQuery();

				con.Close();
				
				getAllRecords();
 				
				rest_data();
			}
			
		}
		
		void  rest_data()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
			textBox6.Text = "";
		}
	
		void DataGridView2SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridView2.SelectedRows.Count > 0) {  
				textBox4.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
				textBox1.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
				textBox2.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
				textBox3.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
				textBox5.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
				textBox6.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			rest_data();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			
			if (dataGridView2.SelectedRows.Count > 0) {  
				if (check_name_here(dataGridView2.SelectedRows[0].Cells[0].Value.ToString())) {
			
					delete(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
				
					getAllRecords();
				
					rest_data();
				
				} else {
			
					MessageBox.Show("ان هذه المادة مرتبطة بعمليات");
				}
			}
		}
		
		public bool check_name_here(string id)
		{
			bool ii = true;
			
			OleDbConnection con = DataBase.createConnection();

			String selectSQL = "SELECT * from  sessions where sessions_patient_id=" + id;

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();
			
			if (reader.Read()) {
				
				ii = false;

			}

			reader.Close();

			con.Close();
			
			return ii;
		}
		
		public void delete(string id)
		{
			OleDbConnection con = DataBase.createConnection();
			
			String insertSQL = "DELETE FROM patients where patient_id=" + id;

			OleDbCommand command = new OleDbCommand(insertSQL, con);

			command.ExecuteNonQuery();

			con.Close();
		
		}
		
		

		void TextBox5TextChanged(object sender, EventArgs e)
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]")) {
				textBox5.Text = "";
			}
		}
	

	}
}