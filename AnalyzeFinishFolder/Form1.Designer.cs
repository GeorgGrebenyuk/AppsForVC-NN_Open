
namespace AnalyzeFinishFolder
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.OpenOutFolder = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.StartAnalyze = new System.Windows.Forms.Button();
			this.FBD_OpenOufFolder = new System.Windows.Forms.FolderBrowserDialog();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(169, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Укажите каталог \"Исходящие\":";
			// 
			// OpenOutFolder
			// 
			this.OpenOutFolder.Location = new System.Drawing.Point(188, 8);
			this.OpenOutFolder.Name = "OpenOutFolder";
			this.OpenOutFolder.Size = new System.Drawing.Size(75, 23);
			this.OpenOutFolder.TabIndex = 1;
			this.OpenOutFolder.Text = "Обзор";
			this.OpenOutFolder.UseVisualStyleBackColor = true;
			this.OpenOutFolder.Click += new System.EventHandler(this.OpenOutFolder_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Запустить процедуру анализа:";
			// 
			// StartAnalyze
			// 
			this.StartAnalyze.Location = new System.Drawing.Point(188, 40);
			this.StartAnalyze.Name = "StartAnalyze";
			this.StartAnalyze.Size = new System.Drawing.Size(75, 23);
			this.StartAnalyze.TabIndex = 2;
			this.StartAnalyze.Text = "Запуск";
			this.StartAnalyze.UseVisualStyleBackColor = true;
			this.StartAnalyze.Click += new System.EventHandler(this.StartAnalyze_Click);
			// 
			// FBD_OpenOufFolder
			// 
			this.FBD_OpenOufFolder.HelpRequest += new System.EventHandler(this.FBD_OpenOufFolder_HelpRequest);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(248, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Табличное отображение результатов проверки";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(17, 96);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(974, 342);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(279, 5);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(237, 26);
			this.label4.TabIndex = 0;
			this.label4.Text = "Примечание: файл отчета генерируется \r\nв корне папки \"Исходящие\", разделители \";\"" +
    "\r\n";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.linkLabel1);
			this.groupBox1.Location = new System.Drawing.Point(607, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(384, 82);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "О приложении";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(7, 68);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(120, 13);
			this.linkLabel1.TabIndex = 0;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Страница приложения";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1006, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.StartAnalyze);
			this.Controls.Add(this.OpenOutFolder);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Проверка итоговой сборки";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button OpenOutFolder;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button StartAnalyze;
		private System.Windows.Forms.FolderBrowserDialog FBD_OpenOufFolder;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}

