using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace AnalyzeFinishFolder
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void OpenOutFolder_Click(object sender, EventArgs e) //Button - open out's catalog
		{
			if (FBD_OpenOufFolder.ShowDialog() == DialogResult.Cancel)
				return;
		}

		private void StartAnalyze_Click(object sender, EventArgs e) //Старт процедуры анализа каталога
		{
			Actions.CreateReport(FBD_OpenOufFolder.SelectedPath);

			dataGridView1.ColumnCount = 3;
			dataGridView1.Columns[0].Name = "File's name";
			dataGridView1.Columns[0].Width = 300;
			dataGridView1.Columns[1].Name = "Is name a correct";
			dataGridView1.Columns[1].Width = 60;
			dataGridView1.Columns[2].Name = "Comment";
			dataGridView1.Columns[2].Width = 60;

				foreach (string str in File.ReadLines(Actions.LogFN).Skip(1))
				{
					string[] SingleRow = new string[3] { str.Split(';')[0], str.Split(';')[1], str.Split(';')[2] };
					dataGridView1.Rows.Add(SingleRow);
				}
			File.Delete(Actions.LogFN);
			textBox1.Text = Actions.Errors.ToString();
			Actions.Errors.Clear();

			
			
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) //Таблица для вывода результатов проверки
		{
			
		}

		private void FBD_OpenOufFolder_HelpRequest(object sender, EventArgs e) //Операция открытия Исходящих
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://github.com/GeorgGrebenyuk/AppsForVC-NN_Open");
		}

		private void textBox1_TextChanged(object sender, EventArgs e) //Консоль вывода отчета о недостающих файлах
		{

		}
	}
}
