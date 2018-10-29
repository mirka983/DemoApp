namespace Timesheet
{
	partial class TimesheetForm
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
			this.Close = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.listBox4 = new System.Windows.Forms.ListBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Close
			// 
			this.Close.Location = new System.Drawing.Point(1, 40);
			this.Close.Name = "Close";
			this.Close.Size = new System.Drawing.Size(93, 30);
			this.Close.TabIndex = 0;
			this.Close.Text = "Close";
			this.Close.UseVisualStyleBackColor = true;
			this.Close.Click += new System.EventHandler(this.button1_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(100, 40);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(130, 30);
			this.listBox1.TabIndex = 1;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(236, 40);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(127, 30);
			this.listBox2.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(766, 38);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 29);
			this.button1.TabIndex = 3;
			this.button1.Text = "Start";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(847, 38);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 30);
			this.button2.TabIndex = 4;
			this.button2.Text = "Break";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// listBox3
			// 
			this.listBox3.FormattingEnabled = true;
			this.listBox3.Location = new System.Drawing.Point(369, 40);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(120, 30);
			this.listBox3.TabIndex = 5;
			// 
			// listBox4
			// 
			this.listBox4.FormattingEnabled = true;
			this.listBox4.Location = new System.Drawing.Point(495, 40);
			this.listBox4.Name = "listBox4";
			this.listBox4.Size = new System.Drawing.Size(124, 30);
			this.listBox4.TabIndex = 6;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(625, 40);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(135, 28);
			this.textBox1.TabIndex = 7;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(100, 14);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(130, 20);
			this.textBox2.TabIndex = 8;
			this.textBox2.Text = "Client";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(236, 14);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(127, 20);
			this.textBox3.TabIndex = 9;
			this.textBox3.Text = "Job ID";
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(369, 12);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(120, 20);
			this.textBox4.TabIndex = 10;
			this.textBox4.Text = "Activity ID";
			this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(495, 12);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(124, 20);
			this.textBox5.TabIndex = 11;
			this.textBox5.Text = "Contact Person";
			this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(625, 12);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(135, 20);
			this.textBox6.TabIndex = 12;
			this.textBox6.Text = "Comment";
			this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(925, 486);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.listBox4);
			this.Controls.Add(this.listBox3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.Close);
			this.Name = "Form1";
			this.Text = "Timesheet";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Close;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.ListBox listBox4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
	}
}

