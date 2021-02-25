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
			Actions.CreateReport(@"D:\Dropbox\NN_Copy\L15_638\Исходящие");

			using (var reader = new StringReader(Actions.Report.ToString()))
			{
				foreach (string str in File.ReadLines(Actions.LogFN))
				{
					string[] SingleRow = new string[3] { str.Split(';')[0], str.Split(';')[1], str.Split(';')[2] };
					dataGridView1.Rows.Add(SingleRow);
				}
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) //Таблица для вывода результатов проверки
		{
			
		}

		private void FBD_OpenOufFolder_HelpRequest(object sender, EventArgs e) //Операция открытия Исходящих
		{

		}
	}
}
