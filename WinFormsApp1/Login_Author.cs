using EFD2.mymodels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
	public partial class Login_Author : Form
	{
		ITIContext f3;
		public Author test;
		public Login_Author()
		{
			InitializeComponent();
			f3 = new ITIContext();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Author author = new Author() { Email = textBox2.Text, Password = textBox1.Text };
			test = f3.Authors.Where(a => a.Email == author.Email).FirstOrDefault();
			if (test != null)
			{
				this.Close();
			}

		}
	}
}
