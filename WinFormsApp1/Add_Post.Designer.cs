namespace WinFormsApp1
{
	partial class Add_Post
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button1 = new Button();
			button2 = new Button();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			comboBox1 = new ComboBox();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(392, 272);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 0;
			button1.Text = "Save";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(35, 390);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 1;
			button2.Text = "Back";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(239, 56);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(586, 61);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(100, 23);
			textBox2.TabIndex = 3;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(239, 175);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(100, 23);
			textBox3.TabIndex = 4;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(182, 59);
			label1.Name = "label1";
			label1.Size = new Size(29, 15);
			label1.TabIndex = 8;
			label1.Text = "Title";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(532, 64);
			label2.Name = "label2";
			label2.Size = new Size(28, 15);
			label2.TabIndex = 9;
			label2.Text = "Bref";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(166, 180);
			label3.Name = "label3";
			label3.Size = new Size(67, 15);
			label3.TabIndex = 10;
			label3.Text = "Description";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(532, 180);
			label4.Name = "label4";
			label4.Size = new Size(48, 15);
			label4.TabIndex = 11;
			label4.Text = "Catalog";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(586, 180);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(121, 23);
			comboBox1.TabIndex = 12;
			// 
			// Add_Post
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(comboBox1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(button2);
			Controls.Add(button1);
			Name = "Add_Post";
			Text = "Add_Post";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Button button2;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private ComboBox comboBox1;
	}
}