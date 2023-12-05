using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
	public partial class Add_New_Catalog : Form
	{
		public string[] ReturnedData = new string[2];
		public Add_New_Catalog()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ReturnedData[0] = textBox1.Text;
			ReturnedData[1] = textBox2.Text;
			this.Close();

		}
	}
}
