using EFD2.mymodels;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		ITIContext db;
		public Author login_author;
		public Post post;
		public Form1()
		{
			db = new ITIContext();

			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Register_Author f2 = new Register_Author();
			f2.ShowDialog();
			if (f2.ReturnedData is not null)
			{
				Author author = new Author()
				{
					Username = f2.ReturnedData[0],
					Email = f2.ReturnedData[1],
					age = int.Parse(f2.ReturnedData[3])
				};


				db.Authors.Add(author);
				db.SaveChanges();

			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Login_Author login_Author = new Login_Author();
			login_Author.ShowDialog();
			if (login_Author is not null)
			{
				login_author = login_Author.test;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Show_All_Forms show_All_Forms = new Show_All_Forms();
			show_All_Forms.ShowDialog();

		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (login_author is null)
			{
				Login_Author login_Author = new Login_Author();
				login_Author.ShowDialog();
				if (login_Author is not null)
				{
					login_author = login_Author.test;
				}
				login_Author.Close();
			}
			Show_My_Posts show_My_Posts = new Show_My_Posts(login_author);
			show_My_Posts.ShowDialog();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Show_All_Catalog show_All_Catalog = new Show_All_Catalog();
			show_All_Catalog.ShowDialog();

		}

		private void button7_Click(object sender, EventArgs e)
		{
			Add_New_Catalog add_New_Catalog = new Add_New_Catalog();
			add_New_Catalog.ShowDialog();
			if (add_New_Catalog.ReturnedData is not null)
			{
				Catalog catalog = new Catalog()
				{
					Name = add_New_Catalog.ReturnedData[0],
					Description = add_New_Catalog.ReturnedData[1],

				};


				db.Catalogs.Add(catalog);
				db.SaveChanges();

			}

		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (login_author is null)
			{
				Login_Author login_Author = new Login_Author();
				login_Author.ShowDialog();
				if (login_Author is not null)
				{
					login_author = login_Author.test;
				}
				login_Author.Close();
			}
			Edit_My_Profile edit_My_Profile = new Edit_My_Profile(login_author);
			edit_My_Profile.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (login_author is null)
			{
				Login_Author login_Author = new Login_Author();
				login_Author.ShowDialog();
				if (login_Author is not null)
				{
					login_author = login_Author.test;
				}
				login_Author.Close();
			}
			Add_Post add_Post = new Add_Post(login_author);
			add_Post.ShowDialog();

		}
	}
}