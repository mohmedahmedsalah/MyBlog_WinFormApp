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
	public partial class Show_All_Forms : Form
	{
		ITIContext db;
		public Show_All_Forms()
		{
			InitializeComponent();
			db = new ITIContext();
			this.Load += Show_All_Forms_Load;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dataGridView1.DataSource = db.Posts.ToList();
		}
		private void Show_All_Forms_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = db.Posts.ToList();



			//btn_update.Visible = false;
			//btn_del.Visible = false;
		}
	}
}
