namespace Timesheet.Presentation
{
	partial class Timesheet
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
			if (disposing && (this.components != null))
			{
				this.components.Dispose();
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
			this.components = new System.ComponentModel.Container();
			this.buttonClose = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.vezbaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.JobId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ActivityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.vezbaDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonClose
			// 
			this.buttonClose.Location = new System.Drawing.Point(0, 0);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(75, 23);
			this.buttonClose.TabIndex = 15;
			// 
			// button2
			// 
			this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button2.AutoSize = true;
			this.button2.BackColor = System.Drawing.Color.Silver;
			this.button2.Location = new System.Drawing.Point(750, 38);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(42, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Start";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button3.AutoSize = true;
			this.button3.BackColor = System.Drawing.Color.Silver;
			this.button3.Location = new System.Drawing.Point(798, 38);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(45, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Break";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(170, 40);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 3;
			// 
			// comboBox2
			// 
			this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.comboBox2.DataSource = this.vezbaDataSetBindingSource;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(93, 40);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(71, 21);
			this.comboBox2.TabIndex = 4;
			// 
			// comboBox3
			// 
			this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(297, 40);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 21);
			this.comboBox3.TabIndex = 5;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox1.Location = new System.Drawing.Point(424, 41);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(129, 20);
			this.textBox1.TabIndex = 6;
			// 
			// textBox2
			// 
			this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textBox2.Location = new System.Drawing.Point(563, 41);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(181, 20);
			this.textBox2.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(170, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Client";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(90, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "JobId";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(294, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Activity Name";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(421, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Contact Person";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(560, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Comments";
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartTime,
            this.EndTime,
            this.JobId,
            this.Client,
            this.ContactPerson,
            this.ActivityName,
            this.Duration,
            this.Comments});
			this.dataGridView1.Location = new System.Drawing.Point(24, 67);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(819, 159);
			this.dataGridView1.TabIndex = 13;
			// 
			// StartTime
			// 
			this.StartTime.HeaderText = "StartTime";
			this.StartTime.Name = "StartTime";
			// 
			// EndTime
			// 
			this.EndTime.HeaderText = "EndTime";
			this.EndTime.Name = "EndTime";
			// 
			// JobId
			// 
			this.JobId.HeaderText = "JobId";
			this.JobId.Name = "JobId";
			// 
			// Client
			// 
			this.Client.HeaderText = "Client";
			this.Client.Name = "Client";
			// 
			// ContactPerson
			// 
			this.ContactPerson.HeaderText = "ContactPerson";
			this.ContactPerson.Name = "ContactPerson";
			// 
			// ActivityName
			// 
			this.ActivityName.HeaderText = "ActivityName";
			this.ActivityName.Name = "ActivityName";
			// 
			// Duration
			// 
			this.Duration.HeaderText = "Duration";
			this.Duration.Name = "Duration";
			// 
			// Comments
			// 
			this.Comments.HeaderText = "Comments";
			this.Comments.Name = "Comments";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(23, 23);
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 244);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size(887, 22);
			this.statusBar1.TabIndex = 16;
			// 
			// statusBarPanel1
			// 
			this.statusBarPanel1.Name = "statusBarPanel1";
			this.statusBarPanel1.Text = "statusBarPanel1";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Timesheet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(887, 266);
			this.Controls.Add(this.statusBar1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.buttonClose);
			this.Name = "Timesheet";
			this.Text = "Timesheet";
			((System.ComponentModel.ISupportInitialize)(this.vezbaDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn JobId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Client;
		private System.Windows.Forms.DataGridViewTextBoxColumn ContactPerson;
		private System.Windows.Forms.DataGridViewTextBoxColumn ActivityName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
		private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
		//private vezbaDataSet vezbaDataSet;
		private System.Windows.Forms.BindingSource vezbaDataSetBindingSource;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		//private EventHandler labelContactPerson_Click;
	}
}