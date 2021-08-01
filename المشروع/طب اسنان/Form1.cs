using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace طب_اسنان
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();

		}
		
		void Button1Click(object sender, EventArgs e)
		{
			new Form4().ShowDialog();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			new Form8().ShowDialog();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			new Form7().ShowDialog();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			new Form9().ShowDialog();
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			new Form2().ShowDialog();
		}
	
		void Button9Click(object sender, EventArgs e)
		{
			new Form3().ShowDialog();
		}
		
	}
}