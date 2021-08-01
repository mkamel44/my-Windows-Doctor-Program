using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections;

namespace طب_اسنان
{
	public partial class Form9 : Form
	{
		
		public Form9()
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
		}

		
		void  rest_data()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			pictureBox1.Image = null;
			pictureBox1.Tag = "";
			pictureBox1.Name = "";
		}
	
		void DataGridView2SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridView2.SelectedRows.Count > 0) {  
			
				getRecordsTeeths();
			
			}
		}
		
		public void getRecordsTeeths()
		{
		
			dataGridView1.Rows.Clear();


			OleDbConnection con = DataBase.createConnection();

			String selectSQL = "SELECT * FROM teeths where teeth_patient_id = " + dataGridView2.SelectedRows[0].Cells[0].Value + " order by teeth_id desc";

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();
			
			while (reader.Read()) {
				
				dataGridView1.Rows.Add(new string[] {
					reader["teeth_id"].ToString(),
					reader["teeth_name"].ToString(),
					reader["teeth_note"].ToString(),
					reader["teeth_photo"].ToString()
				                       		
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
			
			
				
				if (pictureBox1.Image != null) {
					pictureBox1.Image.Dispose();
				}
					
				int index = Application.ExecutablePath.LastIndexOf('\\');
				
				string path = Application.ExecutablePath.Substring(0, index) + dataGridView1.SelectedRows[0].Cells[3].Value;
			
				rest_data();
					
				File.Delete(path);
				
				delete(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
				
				getRecordsTeeths();
									
				
			}
				

		}
		
	
		
		public void delete(string id)
		{
			OleDbConnection con = DataBase.createConnection();
			
			String insertSQL = "DELETE FROM teeths where teeth_id=" + id;

			OleDbCommand command = new OleDbCommand(insertSQL, con);

			command.ExecuteNonQuery();

			con.Close();
		
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Stream myStream;
			
			OpenFileDialog openFileDialog1 = new OpenFileDialog();

			openFileDialog1.InitialDirectory = "c:\\";
			
			//openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			
			openFileDialog1.Filter = "صور (*.jpg)|*.jpg";
			
			openFileDialog1.FilterIndex = 2;
			
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK) {
				
				if ((myStream = openFileDialog1.OpenFile()) != null) {
					
					int index = Application.ExecutablePath.LastIndexOf('\\');

					string newfile = "\\images\\big_" + new Random().Next(1000000) + ".jpg";

					string path = Application.ExecutablePath.Substring(0, index) + newfile;

					Image SSS = Image.FromStream(myStream);
								
					if (pictureBox1.Image != null) {
						pictureBox1.Image.Dispose();
					}
								
					pictureBox1.Image = SSS;
			
					pictureBox1.Tag = newfile;
					
					pictureBox1.Name = path;
						
				}
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
		
			try {
			
				if (!textBox1.Text.Trim().Equals("") && !textBox2.Text.Trim().Equals("") && !pictureBox1.Tag.ToString().Trim().Equals("")) {
				
					pictureBox1.Image.Save(pictureBox1.Name);    
				
					OleDbConnection con = DataBase.createConnection();

					String insertSQL = "insert into teeths (teeth_patient_id,teeth_name,teeth_note,teeth_photo) values (" + dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + ",'" + textBox1.Text + "','" + textBox2.Text + "','" + pictureBox1.Tag + "')";

					OleDbCommand command = new OleDbCommand(insertSQL, con);

					command.ExecuteNonQuery();

					con.Close();
			
					getRecordsTeeths();
				
					rest_data();
					

				} else {
					MessageBox.Show("الرجاء التأكد من المدخلات");
				}
			
			} catch (Exception) {
				MessageBox.Show("الرجاء اعادة ادخال البيانات");
			}
				
		
		}
		
		void DataGridView1MouseClick(object sender, MouseEventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0) {  
			
				
				int index = Application.ExecutablePath.LastIndexOf('\\');
				
				string path = Application.ExecutablePath.Substring(0, index) + dataGridView1.SelectedRows[0].Cells[3].Value;
			
				Image SSSS = Image.FromFile(path);
				
				if (pictureBox1.Image != null) {
					pictureBox1.Image.Dispose();
				}
				
				pictureBox1.Image = SSSS;
				
				pictureBox1.Tag = dataGridView1.SelectedRows[0].Cells[3].Value;
					
				pictureBox1.Name = path;
				
				textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
				
				textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
				
						
			}
			
		
		}
		
		
		void Button2Click(object sender, EventArgs e)
		{
			if (!textBox1.Text.Trim().Equals("") && !textBox2.Text.Trim().Equals("") && !pictureBox1.Tag.ToString().Trim().Equals("")) {
				
				if (pictureBox1.Tag.ToString().Equals(dataGridView1.SelectedRows[0].Cells[3].Value)) {
			
					
					OleDbConnection con = DataBase.createConnection();

					String insertSQL = "update teeths set teeth_name='" + textBox1.Text + "' , teeth_note='" + textBox2.Text + "', teeth_photo='" + pictureBox1.Tag + "' where teeth_id =" + dataGridView1.SelectedRows[0].Cells[0].Value;

					OleDbCommand command = new OleDbCommand(insertSQL, con);

					command.ExecuteNonQuery();

					con.Close();
				
					getRecordsTeeths();
 				
					rest_data();
			
				} else {
			
					
										
					int index = Application.ExecutablePath.LastIndexOf('\\');
				
					string path = Application.ExecutablePath.Substring(0, index) + dataGridView1.SelectedRows[0].Cells[3].Value;
								
					File.Delete(path);
								
					pictureBox1.Image.Save(pictureBox1.Name); 
			
								
					OleDbConnection con = DataBase.createConnection();

					String insertSQL = "update teeths set teeth_name='" + textBox1.Text + "' , teeth_note='" + textBox2.Text + "', teeth_photo='" + pictureBox1.Tag + "' where teeth_id =" + dataGridView1.SelectedRows[0].Cells[0].Value;

					OleDbCommand command = new OleDbCommand(insertSQL, con);

					command.ExecuteNonQuery();

					con.Close();
				
					getRecordsTeeths();
 				
					rest_data();
			
				}
				
			
			}
			
		}
		
			
	

	}
}