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
	public partial class Add_Post : Form
	{
		ITIContext db;
		Author s;
		public Post p;
		public Add_Post(Author w)
		{
			InitializeComponent();
			s = w;
			db = new ITIContext();
			p = new Post();
			comboBox1.DataSource = db.Catalogs.ToList();
			comboBox1.ValueMember = "Cat_id";
			comboBox1.DisplayMember = "Name";

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			p.Title = textBox1.Text;
			p.Bref = textBox2.Text;
			p.Description = textBox3.Text;
			p.Date = DateTime.Now;
			p.Time = DateTime.Now;
			p.Auth_id = s.Auth_id;
			p.Cat_id = (int)comboBox1.SelectedValue;
			db.Posts.Add(p);
			db.SaveChanges();
			Close();



		}
	}
}
