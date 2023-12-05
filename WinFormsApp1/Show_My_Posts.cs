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
	public partial class Show_My_Posts : Form
	{
		ITIContext db;
		Author my;
		public Show_My_Posts()
		{
			InitializeComponent();
			db = new ITIContext();
			this.Load += Show_All_Forms_Load;
		}
		public Show_My_Posts(Author f)
		{
			InitializeComponent();
			db = new ITIContext();
			my = f;
			this.Load += Show_All_Forms_Load;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void Show_All_Forms_Load(object sender, EventArgs e)
		{

			dataGridView1.DataSource = db.Posts.Where(a => a.Auth_id == my.Auth_id).ToList();


		}
	}

}
