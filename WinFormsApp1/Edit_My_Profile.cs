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
	public partial class Edit_My_Profile : Form
	{
		Author author;
		Author a;
		ITIContext db;
		//public Edit_My_Profile()
		//{
		//	InitializeComponent();
		//	author = new Author();
		//	db = new ITIContext();
		//	this.Load += Show_All_Forms_Load;
		//}
		public Edit_My_Profile(Author w)
		{
			InitializeComponent();
			author = w;
			db = new ITIContext();
			this.Load += Show_All_Forms_Load;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();

		}
		private void Show_All_Forms_Load(object sender, EventArgs e)
		{
			a = db.Authors.Where(e => e.Username == author.Username).SingleOrDefault();
			textBox1.Text = author.Username;
			textBox2.Text = author.Email;
			textBox3.Text = author.age.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			a.Username = textBox1.Text;
			a.Email = textBox2.Text;
			a.age = int.Parse(textBox3.Text);
			db.SaveChanges();
			author = null;
			this.Close();
		}
	}
}
