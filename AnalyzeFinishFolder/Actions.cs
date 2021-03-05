using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AnalyzeFinishFolder
{
	public static class Actions
	{
		public static StringBuilder Report = new StringBuilder();
		public static StringBuilder Errors = new StringBuilder();
		//public static int FilesCount = 0;
		public static string LogFN = null;
		//public static StringBuilder ReportTemp = new StringBuilder();
		public static void CreateReport (string PathToOutfolder)
		{
			string guid = Guid.NewGuid().ToString();
			Report.Clear();
			Report.AppendLine("Folder/File name;Is name correct;Comment");
			DirectoryInfo OutgDir = new DirectoryInfo(Path.GetFullPath(PathToOutfolder));
			
			string ParcelDir = new DirectoryInfo(Path.GetDirectoryName(OutgDir.FullName)).Name;
			string SPn = ParcelDir.Replace('_', '-');
			string FinishFolder = PathToOutfolder + "\\" + "2021.03.09-7-Итог";
			//Subfolders
			string FF_Files = FinishFolder + $"\\{SPn}-BIM-файлы";
			string FF_FilesMS = FF_Files + $"\\{SPn}-Model_Studio";
			string FF_Drawings = FinishFolder + $"\\{SPn}-Чертежи";
			string FF_Podacha = FinishFolder + $"\\{SPn}-Подача";
			string FF_Data = FinishFolder + $"\\{SPn}-Собранные_данные";
			//Variables for RVT files:
			int AR_Count = 0;
			bool IsAR_RN = false;
			bool IsGP_RVT = false;


			//Variables for Report's file
			bool IsCorrect = false;
			string Comment = "-";
			if (Directory.Exists(FinishFolder))
			{
				if (Directory.Exists(FF_Files))
				{
					foreach (string str in Directory.GetFiles(FF_Files).Where(d => d.Contains(".rvt"))) //Looking for Revit's files:
					{
						FileInfo InfoAboutFile = new FileInfo(Path.GetFullPath(str));
						string File_Name = InfoAboutFile.Name; //Get file's name and extension
						Technical.CheckTempFile(File_Name);
						Technical.CheckFileName(File_Name);
						if (File_Name.Contains("-АР")) AR_Count++;
						if (File_Name.Contains("Генплан")) IsGP_RVT = true;

						//Analyze data to create a report's variables
						if (Technical.IsTemp == true)
						{
							Comment = "Временный файл";
							IsCorrect = false;
						}
						else if (Technical.Bool_FileName == false)
						{
							Comment = "Неверное название";
							IsCorrect = false;
						}
						else if (Technical.Bool_FileName == true && Technical.IsTemp == false)
						{
							Comment = "-";
							IsCorrect = true;
						}
						Report.AppendLine(File_Name + ';' + IsCorrect + ';' + Comment);
					}
					if (AR_Count < 2) Errors.AppendLine($"Файлов {SPn}-File_Name-АР.rvt недостаточно");
					else if (IsGP_RVT == false) Errors.AppendLine($"Не обнаружен файл {SPn}-Генплан.rvt");

					foreach (string str in Directory.GetFiles(FF_Files).Where(d => d.Contains(".rnp"))) //Looking for Renga's files:
					{
						FileInfo InfoAboutFile = new FileInfo(Path.GetFullPath(str));
						string File_Name = InfoAboutFile.Name; //Get file's name and extension
						Technical.CheckFileName(File_Name);
						if (File_Name.Contains("-АР")) IsAR_RN = true;

						//Analyze data to create a report's variables

						if (Technical.Bool_FileName == false)
						{
							Comment = "Неверное название";
							IsCorrect = false;
						}
						else if (Technical.Bool_FileName == true)
						{
							Comment = "-";
							IsCorrect = true;
						}
						Report.AppendLine(File_Name + ';' + IsCorrect + ';' + Comment);
					}
					if (IsAR_RN == false) Errors.AppendLine($"Файл проекта Renga {SPn}-File_Name-АР.rnp не найден");
				}
				else Errors.AppendLine($"Путь до {SPn}-BIM-файлы не найден!");

				if (Directory.Exists(FF_FilesMS))
				{
					foreach (string str in Directory.GetFiles(FF_FilesMS))
					{
						FileInfo InfoAboutFile = new FileInfo(Path.GetFullPath(str));
						string File_Name = InfoAboutFile.Name; //Get file's name and extension
						Technical.CheckFileName(File_Name);

						//Analyze data to create a report's variables
						if (Technical.Bool_FileName == false)
						{
							Comment = "Неверное название";
							IsCorrect = false;
						}
						else if (Technical.Bool_FileName == true)
						{
							Comment = "-";
							IsCorrect = true;
						}
						Report.AppendLine(File_Name + ';' + IsCorrect + ';' + Comment);
					}		
				}
				else Errors.AppendLine($"Путь до {SPn}-Model_Studio не найден!");

				if (Directory.Exists(FF_Drawings))
				{
					foreach (string str in Directory.GetFiles(FF_Drawings))
					{
						FileInfo InfoAboutFile = new FileInfo(Path.GetFullPath(str));
						string File_Name = InfoAboutFile.Name; //Get file's name and extension
						Technical.CheckFileName(File_Name);

						//Analyze data to create a report's variables
						if (Technical.Bool_FileName == false)
						{
							Comment = "Неверное название";
							IsCorrect = false;
						}
						else if (Technical.Bool_FileName == true)
						{
							Comment = "-";
							IsCorrect = true;
						}
						Report.AppendLine(File_Name + ';' + IsCorrect + ';' + Comment);
					}
				}
				if (Directory.Exists (FF_Podacha))
				{
					int LumF = 0;
					foreach (string str in Directory.GetFiles(FF_Podacha).Where (d=>d.Contains($"{SPn}-Lumion.ls")))
						{
						LumF++;
					}
					if (LumF >0) Report.AppendLine($"{SPn}-Lumion.ls*" + ';'+ "True" + ';'+  "-");
					else Errors.AppendLine($"Файл проекта {SPn}-Lumion.ls* не найден");

					foreach (string str in Directory.GetFiles(FF_Podacha).Where(d => !d.Contains("Lumion.ls")))
					{
						FileInfo InfoAboutFile = new FileInfo(Path.GetFullPath(str));
						string File_Name = InfoAboutFile.Name; //Get file's name and extension
						Technical.CheckFileName(File_Name);

						//Analyze data to create a report's variables
						if (Technical.Bool_FileName == false)
						{
							Comment = "Неверное название";
							IsCorrect = false;
						}
						else if (Technical.Bool_FileName == true)
						{
							Comment = "-";
							IsCorrect = true;
						}
						Report.AppendLine(File_Name + ';' + IsCorrect + ';' + Comment);
					}

				}
				//Check files in root folder (Итог)
				//Файл Сборки
				if (File.Exists(FinishFolder + $"\\{SPn}-Сборка.nwd")) Report.AppendLine($"{SPn}-Сборка.nwd" + ';' + "True" + ';' + "-");
				else Errors.AppendLine($"{SPn}-Сборка.nwd не найдена или неверно названа");
				//Файл сборки с пересечками
				if (File.Exists(FinishFolder + $"\\{SPn}-Сборка-4D+Пересечения.nwd")) Report.AppendLine($"{SPn}-Сборка-4D+Пересечения.nwd" + ';' + "True" + ';' + "-");
				else Errors.AppendLine($"{SPn}-Сборка-4D+Пересечения.nwd не найдена или неверное названа");
				//Файлы презентации
				if (File.Exists(FinishFolder + $"\\{SPn}-Презентация.pptx")) Report.AppendLine($"{SPn}-Презентация.pptx" + ';' + "True" + ';' + "-");
				else Errors.AppendLine($"{SPn}-Презентация.pptx не найдена или неверно названа");
				if (File.Exists(FinishFolder + $"\\{SPn}-Презентация.pdf")) Report.AppendLine($"{SPn}-Презентация.pdf" + ';' + "True" + ';' + "-");
				else Errors.AppendLine($"{SPn}-Презентация.pdf не найден или неверно назван");
				//Файлы ВЕР
				if (File.Exists(FinishFolder + $"\\{SPn}-BEP.docx")) Report.AppendLine($"{SPn}-BEP.docx" + ';' + "True" + ';' + "-");
				else Errors.AppendLine($"{SPn}-BEP.docx не найден или неверно назван");
				if (File.Exists(FinishFolder + $"\\{SPn}-BEP.pdf")) Report.AppendLine($"{SPn}-BEP.pdf" +';'+ "True" + ';' + "-");
				else Errors.AppendLine($"{SPn}-BEP.pdf не найден или неверно назван");
				//График МРР
				if (File.Exists(FinishFolder + $"\\{SPn}-График.mpp")) Report.AppendLine($"{SPn}-График.mpp" + ';' + "True" + ';' + "-");
				else if (File.Exists(FinishFolder + $"\\{SPn}-График.csv")) Report.AppendLine($"{SPn}-График.csv" + ';' + "True" + ';' + "-");
				else Errors.AppendLine($"{SPn}-График.mpp/csv не найден или неверно назван");
			}
			else Errors.AppendLine("Путь до итоговой папки не найден!");
			LogFN = PathToOutfolder + $"\\Log-{guid}.csv";
			File.AppendAllText(LogFN, Report.ToString());
			Report.Clear();
		}

	}
}
