/*
 * Created by SharpDevelop.
 * User: mkamel
 * Date: 12/02/2019
 * Time: 06:47 ص
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace طب_اسنان
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form5());
			Form6 dd = new Form6();
			Application.Run(dd);

			if (dd.Bo)
				Application.Run(new Form1());
		
		}
		
	}
}
